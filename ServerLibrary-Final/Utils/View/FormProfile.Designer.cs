namespace ServerLibrary.View
{
	partial class FormProfile
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.txtHoTen = new System.Windows.Forms.Label();
			this.txtNgaySinh = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(332, 151);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Họ tên:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(332, 199);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ngày sinh:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(332, 245);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Địa chỉ:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(332, 294);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 24);
			this.label4.TabIndex = 4;
			this.label4.Text = "Tên người dùng:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ServerLibrary.Properties.Resources.user1;
			this.pictureBox1.Location = new System.Drawing.Point(58, 153);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Image = global::ServerLibrary.Properties.Resources.back;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(58, 66);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(114, 44);
			this.button2.TabIndex = 42;
			this.button2.Text = "Quay lại";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtHoTen
			// 
			this.txtHoTen.AutoSize = true;
			this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHoTen.Location = new System.Drawing.Point(497, 151);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(134, 24);
			this.txtHoTen.TabIndex = 43;
			this.txtHoTen.Text = "Nguyễn Văn A";
			// 
			// txtNgaySinh
			// 
			this.txtNgaySinh.AutoSize = true;
			this.txtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNgaySinh.Location = new System.Drawing.Point(497, 199);
			this.txtNgaySinh.Name = "txtNgaySinh";
			this.txtNgaySinh.Size = new System.Drawing.Size(100, 24);
			this.txtNgaySinh.TabIndex = 44;
			this.txtNgaySinh.Text = "01/01/2001";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.AutoSize = true;
			this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiaChi.Location = new System.Drawing.Point(497, 245);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(38, 24);
			this.txtDiaChi.TabIndex = 45;
			this.txtDiaChi.Text = "HN";
			// 
			// txtUsername
			// 
			this.txtUsername.AutoSize = true;
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(497, 294);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(62, 24);
			this.txtUsername.TabIndex = 46;
			this.txtUsername.Text = "admin";
			// 
			// FormProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.txtDiaChi);
			this.Controls.Add(this.txtNgaySinh);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormProfile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Trang cá nhân";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProfile_FormClosing);
			this.Load += new System.EventHandler(this.FormProfile_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label txtHoTen;
		private System.Windows.Forms.Label txtNgaySinh;
		private System.Windows.Forms.Label txtDiaChi;
		private System.Windows.Forms.Label txtUsername;
	}
}