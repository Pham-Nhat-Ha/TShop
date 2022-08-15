namespace PRN_TShop
{
    partial class Buy
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.NumericUpDown();
            this.btBuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.cbOrder = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity";
            // 
            // txtQuan
            // 
            this.txtQuan.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuan.Location = new System.Drawing.Point(317, 200);
            this.txtQuan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(242, 36);
            this.txtQuan.TabIndex = 1;
            this.txtQuan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btBuy
            // 
            this.btBuy.BackColor = System.Drawing.Color.Black;
            this.btBuy.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBuy.ForeColor = System.Drawing.Color.White;
            this.btBuy.Location = new System.Drawing.Point(317, 265);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(133, 49);
            this.btBuy.TabIndex = 2;
            this.btBuy.Text = "BUY";
            this.btBuy.UseVisualStyleBackColor = false;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(181, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product";
            // 
            // txtProd
            // 
            this.txtProd.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProd.Location = new System.Drawing.Point(317, 140);
            this.txtProd.Name = "txtProd";
            this.txtProd.ReadOnly = true;
            this.txtProd.Size = new System.Drawing.Size(242, 36);
            this.txtProd.TabIndex = 4;
            // 
            // cbOrder
            // 
            this.cbOrder.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Location = new System.Drawing.Point(317, 78);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(242, 36);
            this.cbOrder.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(181, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Order ID";
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(59)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBuy);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.label1);
            this.Name = "Buy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy";
            ((System.ComponentModel.ISupportInitialize)(this.txtQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtQuan;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.ComboBox cbOrder;
        private System.Windows.Forms.Label label4;
    }
}