namespace RibbonApplication
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.smalImages = new System.Windows.Forms.ImageList(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.largeImages = new System.Windows.Forms.ImageList(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = null;
            this.ribbonControl1.Controller = this.barAndDockingController1;
            // 
            // 
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Images = this.smalImages;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barSubItem1,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barStaticItem1,
            this.barStaticItem2});
            this.ribbonControl1.LargeImages = this.largeImages;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(782, 153);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.barButtonItem1);
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.barSubItem1);
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.LookAndFeel.SkinName = "Black";
            this.barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // smalImages
            // 
            this.smalImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smalImages.ImageStream")));
            this.smalImages.TransparentColor = System.Drawing.Color.Transparent;
            this.smalImages.Images.SetKeyName(0, "64 bit.png");
            this.smalImages.Images.SetKeyName(1, "address books.png");
            this.smalImages.Images.SetKeyName(2, "advanced.png");
            this.smalImages.Images.SetKeyName(3, "applications.png");
            this.smalImages.Images.SetKeyName(4, "archive.png");
            this.smalImages.Images.SetKeyName(5, "back_alt.png");
            this.smalImages.Images.SetKeyName(6, "burn.png");
            this.smalImages.Images.SetKeyName(7, "calculator.png");
            this.smalImages.Images.SetKeyName(8, "cash.png");
            this.smalImages.Images.SetKeyName(9, "color.png");
            this.smalImages.Images.SetKeyName(10, "Computer On.png");
            this.smalImages.Images.SetKeyName(11, "Computer.png");
            this.smalImages.Images.SetKeyName(12, "copy doc.png");
            this.smalImages.Images.SetKeyName(13, "Credit card.png");
            this.smalImages.Images.SetKeyName(14, "delete archive.png");
            this.smalImages.Images.SetKeyName(15, "Desktop 2.png");
            this.smalImages.Images.SetKeyName(16, "down_alt.png");
            this.smalImages.Images.SetKeyName(17, "edit.png");
            this.smalImages.Images.SetKeyName(18, "Ekisho Deep Ocean HD1.png");
            this.smalImages.Images.SetKeyName(19, "exclamation.png");
            this.smalImages.Images.SetKeyName(20, "exit.png");
            this.smalImages.Images.SetKeyName(21, "folder.png");
            this.smalImages.Images.SetKeyName(22, "folder_smart.png");
            this.smalImages.Images.SetKeyName(23, "forward all.png");
            this.smalImages.Images.SetKeyName(24, "forward button white.png");
            this.smalImages.Images.SetKeyName(25, "forward button.png");
            this.smalImages.Images.SetKeyName(26, "forward.png");
            this.smalImages.Images.SetKeyName(27, "forward_alt.png");
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItem1.Caption = "New";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageIndex = 12;
            this.barButtonItem1.LargeImageIndex = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem2.Caption = "Open";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageIndex = 0;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Close";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageIndex = 1;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Print";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageIndex = 2;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Save";
            this.barSubItem1.Id = 5;
            this.barSubItem1.LargeImageIndex = 5;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Save";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Save All";
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Page: 1";
            this.barStaticItem1.Id = 8;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem2.Caption = "About";
            this.barStaticItem2.Id = 9;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // largeImages
            // 
            this.largeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImages.ImageStream")));
            this.largeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImages.Images.SetKeyName(0, "accept.png");
            this.largeImages.Images.SetKeyName(1, "accept_page.png");
            this.largeImages.Images.SetKeyName(2, "add.png");
            this.largeImages.Images.SetKeyName(3, "add_page.png");
            this.largeImages.Images.SetKeyName(4, "add_to_folder.png");
            this.largeImages.Images.SetKeyName(5, "attachment.png");
            this.largeImages.Images.SetKeyName(6, "back.png");
            this.largeImages.Images.SetKeyName(7, "block.png");
            this.largeImages.Images.SetKeyName(8, "calendar.png");
            this.largeImages.Images.SetKeyName(9, "calendar_empty.png");
            this.largeImages.Images.SetKeyName(10, "chart.png");
            this.largeImages.Images.SetKeyName(11, "chart_pie.png");
            this.largeImages.Images.SetKeyName(12, "clock.png");
            this.largeImages.Images.SetKeyName(13, "comment.png");
            this.largeImages.Images.SetKeyName(14, "comments.png");
            this.largeImages.Images.SetKeyName(15, "delete.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup1.ItemLinks.Add(this.barSubItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "File";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem2);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 399);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(782, 24);
            // 
            // galleryControl1
            // 
            this.galleryControl1.Controller = this.barAndDockingController1;
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.DesignGalleryGroupIndex = 0;
            this.galleryControl1.DesignGalleryItemIndex = 0;
            this.galleryControl1.Location = new System.Drawing.Point(0, 0);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(140, 111);
            this.galleryControl1.TabIndex = 1;
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(119, 107);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 423);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.galleryControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private System.Windows.Forms.ImageList smalImages;
        private System.Windows.Forms.ImageList largeImages;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
    }
}

