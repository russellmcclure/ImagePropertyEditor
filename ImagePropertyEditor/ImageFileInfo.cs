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

            this.exifImageFile = ExifLibrary.ImageFile.FromFile(this.fileInfo.FullName);
            var dateTaken = exifImageFile.Properties.Get(ExifLibrary.ExifTag.DateTimeOriginal);
            this.dateTaken = dateTaken == null ? null : (DateTime?)dateTaken.Value;
        } 

        public string FullName {  get {  return fileInfo.FullName; } }

        public void SetDateTaken(DateTime dateTaken)
        {
            this.HasBeenUpdated = true;

            this.dateTaken = dateTaken;
        }

        public void CommitChange()
        {
            if (this.HasBeenUpdated)
            {
                this.exifImageFile.Properties.Set(ExifLibrary.ExifTag.DateTimeOriginal, this.dateTaken.Value);
                this.exifImageFile.Save(this.fileInfo.FullName);
            }
        }

        public bool HasBeenUpdated { get; private set; }

        public DateTime CreationTime
        {
            get
            {
                return fileInfo.CreationTime;
            }
        }

        public DateTime LastAccessTime
        {
            get
            {
                return fileInfo.LastAccessTime;
            }
        }

        public DateTime LastWriteTime
        {
            get
            {
                return fileInfo.LastWriteTime;
            }
        }

        public DateTime? DateTakenCurrent
        {
            get
            {
                return fileInfo.LastWriteTime;
            }
        }

        public DateTime? DateTakenNew
        {
            get
            {
                return fileInfo.CreationTime;
            }
        }
    }
}
