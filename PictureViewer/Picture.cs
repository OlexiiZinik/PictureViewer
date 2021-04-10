using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureViewer
{
    public class Picture
    {
        public Image Image { get; set; }
        public string Path { get; set; }
        public string Name => Path.Split("\\".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Last();
        public string Directory => Path.Split("\\".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Reverse().ToList()[1];

        Picture()
        { 
        }

        public Picture(string path)
        {
            if (!File.Exists(path))
                throw new Exception("File not found");

            Path = path;
            Image = Image.FromFile(path);
            
        }


        public static Picture FromFile(string path)
        {
            return new Picture(path);
        }
    }
}
