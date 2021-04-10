using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public class FileTreeNode : TreeNode
    {

        public Picture Picture { get; set; }

        
        public FileTreeNode() : base()
        {

        }

        public FileTreeNode(string text) : base(text)
        {
        }
        public FileTreeNode(string text, Picture picture) : base(text)
        {
            Picture = picture;
        }
        public FileTreeNode(string text, TreeNode[] children) : base(text, children)
        {
        }

        public FileTreeNode(string text, int imageIndex, int selectedImageIndex) : base(text, imageIndex, selectedImageIndex)
        {
        }

        public FileTreeNode(string text, int imageIndex, int selectedImageIndex, TreeNode[] children) : base(text, imageIndex, selectedImageIndex, children)
        {
        }

        protected FileTreeNode(SerializationInfo serializationInfo, StreamingContext context) : base(serializationInfo, context)
        {
        }
    }
}
