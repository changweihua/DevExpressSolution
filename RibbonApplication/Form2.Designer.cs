namespace RibbonApplication
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "91Wallpaper_280148.jpg");
            this.imageList1.Images.SetKeyName(1, "91Wallpaper_280671.jpg");
            this.imageList1.Images.SetKeyName(2, "91Wallpaper_280793.jpg");
            this.imageList1.Images.SetKeyName(3, "91Wallpaper_280849.jpg");
            this.imageList1.Images.SetKeyName(4, "91Wallpaper_280854.jpg");
            this.imageList1.Images.SetKeyName(5, "91Wallpaper_282818.jpg");
            this.imageList1.Images.SetKeyName(6, "91Wallpaper_282983.jpg");
            this.imageList1.Images.SetKeyName(7, "91Wallpaper_283283.jpg");
            this.imageList1.Images.SetKeyName(8, "91Wallpaper_283446.jpg");
            this.imageList1.Images.SetKeyName(9, "91Wallpaper_283979.jpg");
            this.imageList1.Images.SetKeyName(10, "91Wallpaper_283986.jpg");
            this.imageList1.Images.SetKeyName(11, "91Wallpaper_283989.jpg");
            this.imageList1.Images.SetKeyName(12, "91Wallpaper_283992.jpg");
            // 
            // galleryControl1
            // 
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.DesignGalleryGroupIndex = 0;
            this.galleryControl1.DesignGalleryItemIndex = 0;
            this.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // galleryControlGallery1
            // 
            this.galleryControl1.Gallery.AllowHoverImages = true;
            this.galleryControl1.Gallery.ColumnCount = 3;
            this.galleryControl1.Gallery.DistanceBetweenItems = 100;
            galleryItemGroup1.Caption = "我的素颜";
            galleryItem1.Caption = "Item2";
            galleryItem1.Checked = true;
            galleryItem1.Description = "Description";
            galleryItem1.HoverImage = ((System.Drawing.Image)(resources.GetObject("galleryItem1.HoverImage")));
            galleryItem1.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem1.Image")));
            galleryItem1.ImageIndex = 0;
            galleryItem2.Caption = "Item3";
            galleryItem2.HoverImage = ((System.Drawing.Image)(resources.GetObject("galleryItem2.HoverImage")));
            galleryItem2.HoverImageIndex = 1;
            galleryItem2.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem2.Image")));
            galleryItem2.ImageIndex = 1;
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2});
            galleryItemGroup2.Caption = "其他";
            galleryItem3.Caption = "Item1";
            galleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem3});
            this.galleryControl1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1,
            galleryItemGroup2});
            this.galleryControl1.Gallery.HoverImages = this.imageList1;
            this.galleryControl1.Gallery.HoverImageSize = new System.Drawing.Size(180, 180);
            this.galleryControl1.Gallery.Images = this.imageList1;
            this.galleryControl1.Gallery.ImageSize = new System.Drawing.Size(125, 125);
            this.galleryControl1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right;
            this.galleryControl1.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControl1_Gallery_ItemClick);
            this.galleryControl1.Location = new System.Drawing.Point(0, 0);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(730, 377);
            this.galleryControl1.TabIndex = 0;
            this.galleryControl1.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 24);
            this.galleryControlClient1.Size = new System.Drawing.Size(709, 351);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 377);
            this.Controls.Add(this.galleryControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;

    }
}