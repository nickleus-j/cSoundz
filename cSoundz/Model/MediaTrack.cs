using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace cSoundz.Model
{
    public class MediaTrack
    {
        public string Title { get; set; }
        public string CompleteSource { get; set; }
        public StorageFile File { get; set; }
        public MediaTrack(string title,string src)
        {
            Title = title;
            CompleteSource = src;
        }
        public MediaTrack(StorageFile file)
        {
            File = file;
            Title = File.DisplayName;
            CompleteSource = File.Path;
        }
        public override string ToString()
        {
            return Title;
        }
    }
}
