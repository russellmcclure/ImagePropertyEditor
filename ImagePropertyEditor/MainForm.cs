using ExifLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagePropertyEditor
{
    public partial class MainForm : Form
    {
        private EditorControls editorControls;
        private BindingList<ImageFileInfo> imageFiles;
        private int currentImageFileIndex;
        private string startingMainFormTitle;

        public event EventHandler ImageFilesLoaded;

        private bool imagesLoaded = false;

        public MainForm()
        {
            InitializeComponent();

            this.KeyPreview = true;

            this.editorControls = new EditorControls();

            this.dataGridView.AutoGenerateColumns = false;

            this.pictureViewDateEditor.DateEntered += PictureViewDateEditor_DateEntered;

            this.pictureViewDateEditor.AllowTimeEditing = true;

            // set default values for the preset fields
            this.preset1DateTimePicker.Value = new DateTime(1970, 4, 25, 12, 12, 12);
            this.preset2DateTimePicker.Value = new DateTime(1980, 4, 25, 12, 12, 12);
            this.preset3DateTimePicker.Value = new DateTime(1990, 4, 25, 12, 12, 12);
            this.preset4DateTimePicker.Value = new DateTime(2000, 4, 25, 12, 12, 12);
        }

        private void PictureViewDateEditor_DateEntered(object sender, DateEnteredEventArgs e)
        {
            // this fires when the user has pressed enter in the DateEditor
            if (this.imagesLoaded)
            {
                ImageFileInfo currentImageFileInfo = this.GetCurrentImageFileInfo();

                // if this file type supports ExIf, then lets set the new date there
                if (currentImageFileInfo.HasExif)
                {
                    currentImageFileInfo.NewDateTaken = e.DateEntered;
                }

                // lets always set the modified date
                currentImageFileInfo.NewLastModifiedTime = e.DateEntered;

                // lets save this date as one of our presets to make it easy to reuse it later
                // MAYBE WE DON"T NEED THIS ANYMORE???    this.preset4DateTimePicker.Value = e.DateEntered;

                // now advance to the next image in the list
                this.nextButton_Click(null, EventArgs.Empty);
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            bool? fileDrop = e.Data?.GetDataPresent(DataFormats.FileDrop);
            if (fileDrop.HasValue && fileDrop.Value)
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            var droppedData = (string[])e.Data.GetData(DataFormats.FileDrop);

            // if only one item was dropped and it's a directory
            if (droppedData.Length == 1 && Directory.Exists(droppedData[0]))
            {
                this.selectedDirectoryTextBox.Text = droppedData[0];
            }
            else
            {
                foreach (var fileOrDir in droppedData)
                {
                    // TODO: Deal with multiple directory drops or mix of files and dirs
                }
            }

            int n44 = 44;
            //string[] imageFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            //if (!string.IsNullOrEmpty(imageFiles[0]))
            //{
            //    this.mainPictureBox.Image = Image.FromFile(imageFiles[0]);
            //}

            //var file = ImageFile.FromFile(filename);
            //file.Properties.Set(ExifTag.DateTimeDigitized, dateTime);
            //file.Properties.Set(ExifTag.DateTimeOriginal, dateTime);
            //file.Save(filename);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateMainFormTitle(string currentImageName = null)
        {
            if (!string.IsNullOrEmpty(currentImageName))
            {
                this.Text = this.startingMainFormTitle + " - " + currentImageName;
            }
            else
            {
                this.Text = this.startingMainFormTitle;
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.Refresh();

            //this.editorControls.Show(this);
        }

        private void showEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editorControls.Show(this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if we are closing, give the child form a chance to close first.
            this.editorControls.Close();
        }

        private void setDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.selectedDirectoryTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void loadImagesButton_Click(object sender, EventArgs e)
        {
            // TODO, it's possible that we'll have uncommitted changes that would be lost by this action.  Pop up a message here to confirm with the user that
            // they want to proceed if there are any changes.

            ReloadImages();
        }

        private void ReloadImages()
        {
            if (Directory.Exists(this.selectedDirectoryTextBox.Text))
            {
                string[] fileExtensions = this.fileNameFilterTextBox.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                List<string> imageFileNames = new List<string>();
                foreach (string extension in fileExtensions)
                {
                    imageFileNames.AddRange(Directory.GetFiles(this.selectedDirectoryTextBox.Text, extension, SearchOption.AllDirectories));
                }

                // now load up the meta data for each of the image files we've found
                List<ImageFileInfo> imageFilesTemp = imageFileNames.Select(f => new ImageFileInfo(f)).ToList();

                // we may remove some items from the list before we display them in the GUI
                if (this.onlyIncludeDateTakenNeededCheckBox.Checked)
                {
                    // lets remove any that have already had their Date Taken set or whose ExIf I can't edit programmatically
                    imageFilesTemp.RemoveAll(f => f.DateTaken.HasValue || !f.CanSetDateTaken);
                }

                // sort them by their sortable name
                imageFilesTemp.Sort((a, b) => string.Compare(a.SortableName, b.SortableName));

                // create a bindinglist of our items for display in the GUI
                this.imageFiles = new BindingList<ImageFileInfo>(imageFilesTemp);

                this.OnImageFilesLoaded(EventArgs.Empty);

                int n = 343;
            }
        }

        /// <summary>
        /// THis should be called any time we've changed the contents of the imageFiles collection
        /// </summary>
        private void HandleImageFilesLoaded()
        {
            this.mainPictureBox.Image = null;
            this.dataGridView.Rows.Clear();
            this.dataGridView.DataSource = this.imageFiles;

            if (this.imageFiles.Count > 0)
            {
                this.prevButton.Enabled = true;
                this.nextButton.Enabled = true;

                this.imagesLoaded = true;

                this.currentImageFileIndex = 0;

                ShowNewlySelectedImage();
            }
            else
            {
                // there are no images so let's handle that
                this.prevButton.Enabled = false;
                this.nextButton.Enabled = false;

                this.imagesLoaded = false;

                ClearImageSelection();
            }

        }

        private void ClearImageSelection()
        {
            this.mainPictureBox.ImageLocation = null;
            this.UpdateMainFormTitle();
        }

        private ImageFileInfo GetCurrentImageFileInfo()
        {
            return this.imageFiles[this.currentImageFileIndex];
        }

        private void ShowNewlySelectedImage()
        {
            var newImageFileInfo = this.GetCurrentImageFileInfo();
            this.mainPictureBox.ImageLocation = newImageFileInfo.FullName;
            this.UpdateMainFormTitle(Path.GetFileName(newImageFileInfo.FullName));

            this.dataGridView.ClearSelection();
            this.dataGridView.Rows[this.currentImageFileIndex].Selected = true;

            if (newImageFileInfo.NewDateTaken.HasValue)
            {
                this.pictureViewDateEditor.SetDate(newImageFileInfo.NewDateTaken);
            }
            else if (newImageFileInfo.DateTaken.HasValue)
            {
                this.pictureViewDateEditor.SetDate(newImageFileInfo.DateTaken);
            }
        }

        protected virtual void OnImageFilesLoaded(EventArgs e)
        {
            HandleImageFilesLoaded();

            ImageFilesLoaded?.Invoke(this, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.imageFiles.ForEach(imageFile => imageFile.SetDateTaken(DateTime.Now));

            this.imageFiles.Where(imageFile => imageFile.HasBeenUpdated).ToList().ForEach(imageFile => imageFile.CommitChange());

            this.ReloadImages();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (this.currentImageFileIndex < (this.imageFiles.Count - 1))
            {
                this.currentImageFileIndex++;
                ShowNewlySelectedImage();
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (this.currentImageFileIndex > 0)
            {
                this.currentImageFileIndex--;
                ShowNewlySelectedImage();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.imagesLoaded)
            {
                if (e.KeyCode == Keys.OemPeriod)
                {
                    if (this.nextButton.Enabled)
                    {
                        this.nextButton.PerformClick();
                    }
                }
                else if (e.KeyCode == Keys.Oemcomma)
                {
                    if (this.prevButton.Enabled)
                    {
                        this.prevButton.PerformClick();
                    }
                }
            }
        }

        private void pictureViewDateEditor_Load(object sender, EventArgs e)
        {

        }

        private void applyDateButton_Click(object sender, EventArgs e)
        {
            this.pictureViewDateEditor.SaveDate();
        }

        private void applyPreset1Button_Click(object sender, EventArgs e)
        {
            ApplyPreset(preset1DateTimePicker);
        }

        private void applyPreset2Button_Click(object sender, EventArgs e)
        {
            ApplyPreset(preset2DateTimePicker);
        }

        private void applyPreset3Button_Click(object sender, EventArgs e)
        {
            ApplyPreset(preset3DateTimePicker);
        }

        private void applyPreset4Button_Click(object sender, EventArgs e)
        {
            ApplyPreset(preset4DateTimePicker);
        }

        private void ApplyPreset(DateTimePicker dateTimePicker)
        {
            this.pictureViewDateEditor.SetDate(dateTimePicker.Value);
            this.pictureViewDateEditor.SaveDate();
        }

        private void incAndApplyPreset1Button_Click(object sender, EventArgs e)
        {
            IncrementAndApplyPreset(preset1DateTimePicker);
        }

        private void incAndApplyPreset2Button_Click(object sender, EventArgs e)
        {
            IncrementAndApplyPreset(preset2DateTimePicker);
        }

        private void incAndApplyPreset3Button_Click(object sender, EventArgs e)
        {
            IncrementAndApplyPreset(preset3DateTimePicker);
        }

        private void incAndApplyPreset4Button_Click(object sender, EventArgs e)
        {
            IncrementAndApplyPreset(preset4DateTimePicker);
        }

        private void IncrementAndApplyPreset(DateTimePicker dateTimePicker)
        {
            UpdateAndApplyPreset(dateTimePicker, new TimeSpan(0, 1, 0));
        }

        private void UpdateAndApplyPreset(DateTimePicker dateTimePicker, TimeSpan timeChange)
        {
            dateTimePicker.Value = dateTimePicker.Value.Add(timeChange);
            ApplyPreset(dateTimePicker);
        }

        private void decAndApplyPreset1Button_Click(object sender, EventArgs e)
        {
            DecrementAndApplyPreset(preset1DateTimePicker);
        }

        private void decAndApplyPreset2Button_Click(object sender, EventArgs e)
        {
            DecrementAndApplyPreset(preset2DateTimePicker);
        }

        private void decAndApplyPreset3Button_Click(object sender, EventArgs e)
        {
            DecrementAndApplyPreset(preset3DateTimePicker);
        }

        private void decAndApplyPreset4Button_Click(object sender, EventArgs e)
        {
            DecrementAndApplyPreset(preset4DateTimePicker);
        }

        private void DecrementAndApplyPreset(DateTimePicker dateTimePicker)
        {
            UpdateAndApplyPreset(dateTimePicker, new TimeSpan(0, -1, 0));
        }

        private void storeAsPreset1Button_Click(object sender, EventArgs e)
        {
            StoreAsPreset(preset1DateTimePicker);
        }

        private void storeAsPreset2Button_Click(object sender, EventArgs e)
        {
            StoreAsPreset(preset2DateTimePicker);
        }

        private void storeAsPreset3Button_Click(object sender, EventArgs e)
        {
            StoreAsPreset(preset3DateTimePicker);
        }

        private void storeAsPreset4Button_Click(object sender, EventArgs e)
        {
            StoreAsPreset(preset4DateTimePicker);
        }

        private void StoreAsPreset(DateTimePicker dateTimePicker)
        {
            DateTime? cuurentDateValue = this.pictureViewDateEditor.GetDate();

            if (cuurentDateValue.HasValue)
            {
                dateTimePicker.Value = cuurentDateValue.Value;
            }
        }

        private void applyDeltaToSiblings_Click(object sender, EventArgs e)
        {
            ImageFileInfo currentImageFileInfo = this.GetCurrentImageFileInfo();
            if (currentImageFileInfo != null
                && currentImageFileInfo.DateTaken.HasValue && currentImageFileInfo.NewDateTaken.HasValue)
            {
                TimeSpan delta = currentImageFileInfo.NewDateTaken.Value - currentImageFileInfo.DateTaken.Value;

                int siblingMonth = currentImageFileInfo.DateTaken.Value.Month;
                int siblingYear = currentImageFileInfo.DateTaken.Value.Year;

                ImageFileInfo lastCandidateExamined = currentImageFileInfo;
                // lets walk from the current image towards the beginning of the list 
                for (int i = currentImageFileIndex - 1; i >= 0; i--)
                {
                    // to be a sibling, it must have an original DateTaken that has a value and whose year and month match our target.
                    // it also cannot have already had it's NewDateTaken set yet.
                    // AND it can't a newer DateTaken then the previous candidate we looked at
                    ImageFileInfo candidateToChange = this.imageFiles[i];
                    if (candidateToChange.DateTaken.HasValue
                        && candidateToChange.DateTaken.Value.Year == siblingYear
                        && candidateToChange.DateTaken.Value.Month == siblingMonth
                        && !candidateToChange.NewDateTaken.HasValue
                        && candidateToChange.DateTaken.Value <= lastCandidateExamined.DateTaken.Value)
                    {
                        candidateToChange.NewDateTaken = candidateToChange.DateTaken.Value + delta;

                        // lets always set the modified date
                        candidateToChange.NewLastModifiedTime = candidateToChange.NewDateTaken;
                    }
                    else
                    {
                        break;
                    }

                    lastCandidateExamined = candidateToChange;
                }

                lastCandidateExamined = currentImageFileInfo;
                for (int i = currentImageFileIndex + 1; i < this.imageFiles.Count; i++)
                {
                    // to be a sibling, it must have an original DateTaken that has a value and whose year and month match our target.
                    // it also cannot have already had it's NewDateTaken set yet.
                    // AND it can't a newer DateTaken then the previous candidate we looked at
                    ImageFileInfo candidateToChange = this.imageFiles[i];
                    if (candidateToChange.DateTaken.HasValue
                        && candidateToChange.DateTaken.Value.Year == siblingYear
                        && candidateToChange.DateTaken.Value.Month == siblingMonth
                        && !candidateToChange.NewDateTaken.HasValue
                        && candidateToChange.DateTaken.Value >= lastCandidateExamined.DateTaken.Value)
                    {
                        candidateToChange.NewDateTaken = candidateToChange.DateTaken.Value + delta;

                        // lets always set the modified date
                        candidateToChange.NewLastModifiedTime = candidateToChange.NewDateTaken;
                    }
                    else
                    {
                        break;
                    }

                    lastCandidateExamined = candidateToChange;
                }
                //// get all current images with the same month and year but don't already have a NewDateTaken set
                //foreach (var imageFile in this.imageFiles)
                //    {
                //        // to be a sibling, it must have an original DateTaken that has a value and whose year and month match our target.
                //        // it also cannot have already had it's NewDateTaken set yet.
                //    if (imageFile.DateTaken.HasValue && imageFile.DateTaken.Value.Year == siblingYear && imageFile.DateTaken.Value.Month == siblingMonth && !imageFile.NewDateTaken.HasValue)
                //    {
                //        imageFile.NewDateTaken = imageFile.DateTaken.Value + delta;
                //    }
                //}
            }
            else
            {
                MessageBox.Show("You need to have an existing Date Taken and also have chosen a New Date Taken in order to use this as a delta for other images.");
            }
        }

        private void countOriginalKodakJPGs_Click(object sender, EventArgs e)
        {
            int count = 0;
            string rootFolder = @"D:\Pictures\FamilyPictures";

            List<string> imageFileNames = new List<string>();
            imageFileNames.AddRange(Directory.GetFiles(rootFolder, "*.jpg", SearchOption.AllDirectories));

            // we are only looking for original files (not the copies Brooke made) taken by the Kodak camera
            imageFileNames.RemoveAll(f => !Regex.IsMatch(Path.GetFileNameWithoutExtension(f), @"^100[B_]\d{4}$"));

            //// now load up the meta data for each of the image files we've found
            //List<ImageFileInfo> imageFilesTemp = imageFileNames.Select(f => new ImageFileInfo(f)).ToList();

            //// we are only looking for the "problem" ones where the datetaken is in Jan 2005
            //imageFilesTemp.RemoveAll(f => f.DateTaken.HasValue
            //            && f.DateTaken.Value.Year == 2005
            //            && f.DateTaken.Value.Month == 1);

            foreach (var file in imageFileNames)
            {
                try
                {
                    var imageFile = ExifLibrary.ImageFile.FromFile(file);
                    try
                    {
                        var dateTaken = imageFile.Properties.Get(ExifLibrary.ExifTag.DateTimeOriginal);
                        var convertedDateTaken = dateTaken == null ? null : (DateTime?)dateTaken.Value;

                        if (convertedDateTaken.HasValue 
                            && convertedDateTaken.Value.Year == 2005
                            && convertedDateTaken.Value.Month == 1)
                        {
                            count++;
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                catch
                {
                    // Ignore files that fail to load EXIF data
                }
            }

            //count = imageFilesTemp.Count;


            MessageBox.Show("Count is: " + count);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.currentImageFileIndex = e.RowIndex;
            ShowNewlySelectedImage();
        }
    }
}
