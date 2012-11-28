using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using System.Xml.Linq;
using DevExpress.XtraBars;

namespace RibbonApplication
{
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       Form6
     * 机器名称:       HSERVER
     * 命名空间:       RibbonApplication
     * 文 件 名:       Form6
     * 创建时间:       2012/11/28  8:47:10
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    /// <summary>
    /// Create Ribbon Group dynamicly
    /// </summary>
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            while (ribbonPage1.Groups.Count > 1)
            {
                ribbonPage1.Groups.RemoveAt(1);
            }

            while (imageList1.Images.Count > 3)
            {
                imageList1.Images.RemoveAt(3);
            }

        }

        private void btnOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnClear_ItemClick(sender, e);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RibbonPageGroup dynamicGroup = new RibbonPageGroup("Dynamic");
                ribbonPage1.Groups.Add(dynamicGroup);

                XDocument xml = XDocument.Load(openFileDialog1.FileName);


                var items = from item in xml.Elements("items").Elements("item")
                            select item;

                foreach (var item in items)
                {
                    string buttonName = item.Attribute("name").Value;
                    string imageName = item.Attribute("image").Value;
                    int imageIndex = imageList1.Images.Add(Image.FromFile(imageName), Color.Transparent);

                    BarButtonItem button = new BarButtonItem(ribbonControl1.Manager, buttonName) { ImageIndex=imageIndex };

                    dynamicGroup.ItemLinks.Add(button);

                }

            }

        }
    }
}
