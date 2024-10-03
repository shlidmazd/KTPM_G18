namespace ServerLibrary.View
{
	partial class Dashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			this.btnRanking = new System.Windows.Forms.Button();
			this.btnRecommend = new System.Windows.Forms.Button();
			this.btnProfile = new System.Windows.Forms.Button();
			this.labelMain = new System.Windows.Forms.Label();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.sortBy = new System.Windows.Forms.ComboBox();
			this.sortType = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnRanking
			// 
			this.btnRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRanking.Image = global::ServerLibrary.Properties.Resources.ranking;
			this.btnRanking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRanking.Location = new System.Drawing.Point(479, 72);
			this.btnRanking.Name = "btnRanking";
			this.btnRanking.Size = new System.Drawing.Size(153, 47);
			this.btnRanking.TabIndex = 2;
			this.btnRanking.Text = "BXH";
			this.btnRanking.UseVisualStyleBackColor = true;
			this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
			// 
			// btnRecommend
			// 
			this.btnRecommend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRecommend.Image = global::ServerLibrary.Properties.Resources.forme;
			this.btnRecommend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRecommend.Location = new System.Drawing.Point(651, 72);
			this.btnRecommend.Name = "btnRecommend";
			this.btnRecommend.Size = new System.Drawing.Size(159, 47);
			this.btnRecommend.TabIndex = 1;
			this.btnRecommend.Text = "Gợi ý cho bạn";
			this.btnRecommend.UseVisualStyleBackColor = true;
			this.btnRecommend.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnProfile
			// 
			this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProfile.Image = global::ServerLibrary.Properties.Resources.user;
			this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProfile.Location = new System.Drawing.Point(816, 71);
			this.btnProfile.Name = "btnProfile";
			this.btnProfile.Size = new System.Drawing.Size(127, 48);
			this.btnProfile.TabIndex = 0;
			this.btnProfile.Text = "Cá nhân";
			this.btnProfile.UseVisualStyleBackColor = true;
			this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
			// 
			// labelMain
			// 
			this.labelMain.AutoSize = true;
			this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMain.Location = new System.Drawing.Point(47, 43);
			this.labelMain.Name = "labelMain";
			this.labelMain.Size = new System.Drawing.Size(139, 37);
			this.labelMain.TabIndex = 3;
			this.labelMain.Text = "Thư viện";
			// 
			// mainPanel
			// 
			this.mainPanel.Location = new System.Drawing.Point(54, 183);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(889, 358);
			this.mainPanel.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = global::ServerLibrary.Properties.Resources.heart_full;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(816, 125);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 38);
			this.button1.TabIndex = 5;
			this.button1.Text = "Yêu thích";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Image = global::ServerLibrary.Properties.Resources.eye;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(651, 125);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(159, 38);
			this.button2.TabIndex = 6;
			this.button2.Text = "Đang đọc";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// sortBy
			// 
			this.sortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sortBy.FormattingEnabled = true;
			this.sortBy.Items.AddRange(new object[] {
            "Theo lượt xem",
            "Theo đánh giá"});
			this.sortBy.Location = new System.Drawing.Point(54, 131);
			this.sortBy.Name = "sortBy";
			this.sortBy.Size = new System.Drawing.Size(211, 32);
			this.sortBy.TabIndex = 7;
			this.sortBy.SelectedValueChanged += new System.EventHandler(this.sortBy_SelectedValueChanged);
			// 
			// sortType
			// 
			this.sortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sortType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sortType.FormattingEnabled = true;
			this.sortType.Items.AddRange(new object[] {
            "Tăng dần",
            "Giảm dần"});
			this.sortType.Location = new System.Drawing.Point(282, 131);
			this.sortType.Name = "sortType";
			this.sortType.Size = new System.Drawing.Size(211, 32);
			this.sortType.TabIndex = 8;
			this.sortType.SelectedValueChanged += new System.EventHandler(this.sortType_SelectedValueChanged);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(955, 553);
			this.Controls.Add(this.sortType);
			this.Controls.Add(this.sortBy);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.labelMain);
			this.Controls.Add(this.btnRanking);
			this.Controls.Add(this.btnRecommend);
			this.Controls.Add(this.btnProfile);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Dashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dashboard";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnProfile;
		private System.Windows.Forms.Button btnRecommend;
		private System.Windows.Forms.Button btnRanking;
		private System.Windows.Forms.Label labelMain;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox sortBy;
		private System.Windows.Forms.ComboBox sortType;
	}
}