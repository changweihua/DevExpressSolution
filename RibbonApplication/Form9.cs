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
     * 类 名 称:       Form9
     * 机器名称:       HSERVER
     * 命名空间:       RibbonApplication
     * 文 件 名:       Form9
     * 创建时间:       2012/11/28  14:46:49
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.alertControl1.Show(this, "123", "123456789");
        }

        private void alertControl1_ButtonClick(object sender, DevExpress.XtraBars.Alerter.AlertButtonClickEventArgs e)
        {
            MessageBox.Show(e.Button.Hint);
        }
    }
}
