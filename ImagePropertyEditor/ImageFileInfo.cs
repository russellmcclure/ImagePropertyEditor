using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagePropertyEditor
{
    public class ImageFileInfo
    {
        private FileInfo fileInfo;
        private DateTime? dateTaken = null;

        ExifLibrary.ImageFile exifImageFile;

        public ImageFileInfo(string fileName) : this(new FileInfo(fileName))
        {
        }

        public ImageFileInfo(FileInfo fileInfo)
        {
            this.fileInfo = fileInfo;

            try
            {
                this.exifImageFile = ExifLibrary.ImageFile.FromFile(this.fileInfo.FullName);
                var dateTaken = exifImageFile.Properties.Get(ExifLibrary.ExifTag.DateTimeOriginal);
                this.dateTaken = dateTaken == null ? null : (DateTime?)dateTaken.Value;
            }
            catch (Exception ex)
            {
                // this path will be most likely due to a image file or movie type where the ExifLibrary doesn't support the editing of Exif data.
                this.dateTaken = null;
            }
        } 

        public string FullName {  get {  return fileInfo.FullName; } }

        public bool CanSetDateTaken { get { return this.exifImageFile != null; } }

        public void SetDateTaken(DateTime dateTaken)
        {
            this.dateTaken = dateTaken;
        }

        public void CommitChange()
        {
            if (this.HasBeenUpdated)
            {
                if (CanSetDateTaken && NewDateTaken.HasValue)
                {
                    this.exifImageFile.Properties.Set(ExifLibrary.ExifTag.DateTimeOriginal, this.dateTaken.Value);
                    this.exifImageFile.Save(this.fileInfo.FullName);
                }

                if (this.NewLastModifiedTime.HasValue)
                {
                    this.fileInfo.LastWriteTime = this.NewLastModifiedTime.Value;
                }
            }
        }

        public bool HasBeenUpdated
        {
            get
            {
                return NewLastModifiedTime.HasValue || NewDateTaken.HasValue;
            }
        }

        public bool HasExif
        {
            get
            {
                return this.exifImageFile != null;
            }
        }

        public DateTime CreationTime
        {
            get
            {
                return this.fileInfo.CreationTime;
            }
        }

        public DateTime LastModifiedTime
        {
            get
            {
                return fileInfo.LastWriteTime;
            }
        }

        public DateTime? NewLastModifiedTime { get; set; }

        public DateTime? DateTaken
        {
            get
            {
                return HasExif ? this.dateTaken : (DateTime?)null;
            }
        }

        public DateTime? NewDateTaken { get; set; }
    }
}
