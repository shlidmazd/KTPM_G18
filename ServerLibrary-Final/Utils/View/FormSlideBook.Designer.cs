namespace ServerLibrary.View
{
	partial class FormSlideBook
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
			this.btnLeft = new System.Windows.Forms.Button();
			this.ImageBox = new System.Windows.Forms.PictureBox();
			this.btnRight = new System.Windows.Forms.Button();
			this.tvx = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelTenSach = new System.Windows.Forms.Label();
			this.labelTacGia = new System.Windows.Forms.Label();
			this.labelStar = new System.Windows.Forms.Label();
			this.labelLuotXem = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.idx = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.sizeBook = new System.Windows.Forms.Label();
			this.btnXemChiTiet = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLeft
			// 
			this.btnLeft.Image = global::ServerLibrary.Properties.Resources.left;
			this.btnLeft.Location = new System.Drawing.Point(12, 140);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(60, 60);
			this.btnLeft.TabIndex = 1;
			this.btnLeft.UseVisualStyleBackColor = true;
			this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
			// 
			// ImageBox
			// 
			this.ImageBox.Location = new System.Drawing.Point(102, 58);
			this.ImageBox.Name = "ImageBox";
			this.ImageBox.Size = new System.Drawing.Size(200, 200);
			this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImageBox.TabIndex = 0;
			this.ImageBox.TabStop = false;
			this.ImageBox.Click += new System.EventHandler(this.ImageBox_Click);
			// 
			// btnRight
			// 
			this.btnRight.Image = global::ServerLibrary.Properties.Resources.right;
			this.btnRight.Location = new System.Drawing.Point(324, 140);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(60, 60);
			this.btnRight.TabIndex = 2;
			this.btnRight.UseVisualStyleBackColor = true;
			this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
			// 
			// tvx
			// 
			this.tvx.AutoSize = true;
			this.tvx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tvx.Location = new System.Drawing.Point(419, 108);
			this.tvx.Name = "tvx";
			this.tvx.Size = new System.Drawing.Size(77, 24);
			this.tvx.TabIndex = 3;
			this.tvx.Text = "Tác giả:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(419, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Tên sách:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(419, 156);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Đánh giá:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(419, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Lượt xem:";
			// 
			// labelTenSach
			// 
			this.labelTenSach.AutoSize = true;
			this.labelTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTenSach.Location = new System.Drawing.Point(569, 58);
			this.labelTenSach.Name = "labelTenSach";
			this.labelTenSach.Size = new System.Drawing.Size(48, 24);
			this.labelTenSach.TabIndex = 7;
			this.labelTenSach.Text = "ABC";
			// 
			// labelTacGia
			// 
			this.labelTacGia.AutoSize = true;
			this.labelTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTacGia.Location = new System.Drawing.Point(569, 108);
			this.labelTacGia.Name = "labelTacGia";
			this.labelTacGia.Size = new System.Drawing.Size(48, 24);
			this.labelTacGia.TabIndex = 8;
			this.labelTacGia.Text = "ABC";
			// 
			// labelStar
			// 
			this.labelStar.AutoSize = true;
			this.labelStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStar.Location = new System.Drawing.Point(569, 156);
			this.labelStar.Name = "labelStar";
			this.labelStar.Size = new System.Drawing.Size(48, 24);
			this.labelStar.TabIndex = 9;
			this.labelStar.Text = "ABC";
			// 
			// labelLuotXem
			// 
			this.labelLuotXem.AutoSize = true;
			this.labelLuotXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLuotXem.Location = new System.Drawing.Point(569, 206);
			this.labelLuotXem.Name = "labelLuotXem";
			this.labelLuotXem.Size = new System.Drawing.Size(48, 24);
			this.labelLuotXem.TabIndex = 10;
			this.labelLuotXem.Text = "ABC";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ServerLibrary.Properties.Resources.star_full;
			this.pictureBox1.Location = new System.Drawing.Point(623, 156);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// idx
			// 
			this.idx.AutoSize = true;
			this.idx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idx.Location = new System.Drawing.Point(149, 283);
			this.idx.Name = "idx";
			this.idx.Size = new System.Drawing.Size(30, 24);
			this.idx.TabIndex = 12;
			this.idx.Text = "01";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(185, 283);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(15, 24);
			this.label9.TabIndex = 13;
			this.label9.Text = "/";
			// 
			// sizeBook
			// 
			this.sizeBook.AutoSize = true;
			this.sizeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sizeBook.Location = new System.Drawing.Point(206, 283);
			this.sizeBook.Name = "sizeBook";
			this.sizeBook.Size = new System.Drawing.Size(30, 24);
			this.sizeBook.TabIndex = 14;
			this.sizeBook.Text = "01";
			// 
			// btnXemChiTiet
			// 
			this.btnXemChiTiet.Image = global::ServerLibrary.Properties.Resources.find;
			this.btnXemChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXemChiTiet.Location = new System.Drawing.Point(423, 274);
			this.btnXemChiTiet.Name = "btnXemChiTiet";
			this.btnXemChiTiet.Size = new System.Drawing.Size(133, 46);
			this.btnXemChiTiet.TabIndex = 15;
			this.btnXemChiTiet.Text = "Xem chi tiết";
			this.btnXemChiTiet.UseVisualStyleBackColor = true;
			this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
			// 
			// FormSlideBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 358);
			this.Controls.Add(this.btnXemChiTiet);
			this.Controls.Add(this.sizeBook);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.idx);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelLuotXem);
			this.Controls.Add(this.labelStar);
			this.Controls.Add(this.labelTacGia);
			this.Controls.Add(this.labelTenSach);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tvx);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.btnLeft);
			this.Controls.Add(this.ImageBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormSlideBook";
			this.Text = "FormSlideBook";
			this.Load += new System.EventHandler(this.FormSlideBook_Load);
			((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox ImageBox;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Label tvx;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelTenSach;
		private System.Windows.Forms.Label labelTacGia;
		private System.Windows.Forms.Label labelStar;
		private System.Windows.Forms.Label labelLuotXem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label idx;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label sizeBook;
		private System.Windows.Forms.Button btnXemChiTiet;
	}
}