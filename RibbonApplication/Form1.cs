using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace RibbonApplication
{
    /// <summary>
    /// Ribbon Group Edit Control
    /// </summary>
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 展开整个Gallary时触发并调用该方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ribbonGalleryBarItem1_Gallery_InitDropDownGallery(object sender, InplaceGalleryEventArgs e)
        {
            e.PopupGallery.ColumnCount = 1;
            e.PopupGallery.ShowItemText = true;
            e.PopupGallery.Images = rgHoverImages;
            e.PopupGallery.AllowHoverImages = false;
        }
    }
}
