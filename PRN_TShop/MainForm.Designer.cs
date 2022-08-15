namespace PRN_TShop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.categoryM = new System.Windows.Forms.ToolStripMenuItem();
            this.allMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editCat = new System.Windows.Forms.ToolStripMenuItem();
            this.orderM = new System.Windows.Forms.ToolStripMenuItem();
            this.allOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryM,
            this.orderM});
            this.menu.Location = new System.Drawing.Point(759, 101);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(477, 52);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // categoryM
            // 
            this.categoryM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allMenu,
            this.editCat});
            this.categoryM.Name = "categoryM";
            this.categoryM.Size = new System.Drawing.Size(206, 48);
            this.categoryM.Text = "CATEGORY";
            // 
            // allMenu
            // 
            this.allMenu.Name = "allMenu";
            this.allMenu.Size = new System.Drawing.Size(295, 48);
            this.allMenu.Text = "All Menu";
            this.allMenu.Click += new System.EventHandler(this.allMenu_Click);
            // 
            // editCat
            // 
            this.editCat.Name = "editCat";
            this.editCat.Size = new System.Drawing.Size(295, 48);
            this.editCat.Text = "Edit Category";
            this.editCat.Click += new System.EventHandler(this.editCat_Click_1);
            // 
            // orderM
            // 
            this.orderM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allOrdersToolStripMenuItem});
            this.orderM.Name = "orderM";
            this.orderM.Size = new System.Drawing.Size(143, 48);
            this.orderM.Text = "ORDER";
            // 
            // allOrdersToolStripMenuItem
            // 
            this.allOrdersToolStripMenuItem.Name = "allOrdersToolStripMenuItem";
            this.allOrdersToolStripMenuItem.Size = new System.Drawing.Size(247, 48);
            this.allOrdersToolStripMenuItem.Text = "All Orders";
            this.allOrdersToolStripMenuItem.Click += new System.EventHandler(this.allOrdersToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(59)))), ((int)(((byte)(61)))));
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(754, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to TShop!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-514, 508);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1920, 833);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(59)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox2);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "WELCOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem categoryM;
        private System.Windows.Forms.ToolStripMenuItem orderM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem allMenu;
        private System.Windows.Forms.ToolStripMenuItem editCat;
        private System.Windows.Forms.ToolStripMenuItem allOrdersToolStripMenuItem;
    }
}
