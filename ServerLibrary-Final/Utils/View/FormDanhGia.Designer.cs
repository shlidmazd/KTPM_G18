namespace ServerLibrary.View
{
	partial class FormDanhGia
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
			this.lbUsername = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.tbContent = new System.Windows.Forms.TextBox();
			this.prev = new System.Windows.Forms.Button();
			this.next = new System.Windows.Forms.Button();
			this.paging = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbStar = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbUsername
			// 
			this.lbUsername.AutoSize = true;
			this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsername.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lbUsername.Location = new System.Drawing.Point(164, 12);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(0, 18);
			this.lbUsername.TabIndex = 1;
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbName.Location = new System.Drawing.Point(162, 46);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(0, 25);
			this.lbName.TabIndex = 2;
			// 
			// tbContent
			// 
			this.tbContent.BackColor = System.Drawing.SystemColors.Control;
			this.tbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbContent.Location = new System.Drawing.Point(40, 123);
			this.tbContent.Multiline = true;
			this.tbContent.Name = "tbContent";
			this.tbContent.ReadOnly = true;
			this.tbContent.Size = new System.Drawing.Size(407, 109);
			this.tbContent.TabIndex = 4;
			// 
			// prev
			// 
			this.prev.Location = new System.Drawing.Point(40, 255);
			this.prev.Name = "prev";
			this.prev.Size = new System.Drawing.Size(75, 23);
			this.prev.TabIndex = 5;
			this.prev.Text = "<";
			this.prev.UseVisualStyleBackColor = true;
			this.prev.Click += new System.EventHandler(this.prev_Click);
			// 
			// next
			// 
			this.next.Location = new System.Drawing.Point(372, 255);
			this.next.Name = "next";
			this.next.Size = new System.Drawing.Size(75, 23);
			this.next.TabIndex = 6;
			this.next.Text = ">";
			this.next.UseVisualStyleBackColor = true;
			this.next.Click += new System.EventHandler(this.next_Click);
			// 
			// paging
			// 
			this.paging.AutoSize = true;
			this.paging.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paging.Location = new System.Drawing.Point(224, 258);
			this.paging.Name = "paging";
			this.paging.Size = new System.Drawing.Size(40, 20);
			this.paging.TabIndex = 7;
			this.paging.Text = "1/99";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::ServerLibrary.Properties.Resources.star_full;
			this.pictureBox2.Location = new System.Drawing.Point(192, 82);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 31;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ServerLibrary.Properties.Resources.user1;
			this.pictureBox1.Location = new System.Drawing.Point(40, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(90, 90);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lbStar
			// 
			this.lbStar.AutoSize = true;
			this.lbStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbStar.ForeColor = System.Drawing.Color.Red;
			this.lbStar.Location = new System.Drawing.Point(162, 77);
			this.lbStar.Name = "lbStar";
			this.lbStar.Size = new System.Drawing.Size(24, 25);
			this.lbStar.TabIndex = 32;
			this.lbStar.Text = "5";
			// 
			// FormDanhGia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 290);
			this.Controls.Add(this.lbStar);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.paging);
			this.Controls.Add(this.next);
			this.Controls.Add(this.prev);
			this.Controls.Add(this.tbContent);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.lbUsername);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormDanhGia";
			this.Text = "FormDanhGia";
			this.Load += new System.EventHandler(this.FormDanhGia_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.TextBox tbContent;
		private System.Windows.Forms.Button prev;
		private System.Windows.Forms.Button next;
		private System.Windows.Forms.Label paging;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbStar;
	}
}