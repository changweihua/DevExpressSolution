﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RibbonApplication
{
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       Form2
     * 机器名称:       HSERVER
     * 命名空间:       RibbonApplication
     * 文 件 名:       Form2
     * 创建时间:       2012/11/26  16:28:06
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
    /// Usage of Gallary Control 
    /// </summary>
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void galleryControl1_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            MessageBox.Show("aaaaaaaa");
        }
    }
}
