using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PictureViewer
{
    public delegate void ItemClickEvent(object sender, EventArgs e, object item);



    public class ContextMenuExt : ContextMenuStrip
    {
        public object Item { get; set; }

        public ContextMenuExt()
        {
        }

        public ContextMenuExt(IContainer container) : base(container)
        {
        }

        public ContextMenuExt(IContainer container, object item) : base(container)
        {
            Item = item;
            base.ItemClicked += ClickResolver;
        }

        private void ClickResolver(object sender, EventArgs e)
        {
            ItemClickedExt?.Invoke(sender, e, Item);
        }

        public event ItemClickEvent ItemClickedExt;
    }
}
