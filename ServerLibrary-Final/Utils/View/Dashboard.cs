using ServerLibrary.Extensions;
using ServerLibrary.Repository;
using ServerLibrary.Repository.Common;
using ServerLibrary.Services;
using ServerLibrary.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerLibrary.View
{
	public partial class Dashboard : Form
	{
		
		private FormSlideBook form;
		private FilterBuilder filterBuilder = new FilterBuilder();
		private bool IsShowBXH = true;
		public Dashboard()
		{
			InitializeComponent();
		}

		private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void btnProfile_Click(object sender, EventArgs e)
		{
			new FormProfile(this).Show();
			this.Hide();
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			filterBuilder = new FilterBuilder()
				.SortBy(SortBy.ViewCount)
				.SortType(SortType.Descending);
			var listBook = BookService.GetInstance().Filter(filterBuilder.Build()).Select(m => m.ToDTO()).ToList();
			form = new FormSlideBook(this);
			form.TopLevel = false;
			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(form);
			form.Show();

			sortBy.SelectedIndex = 0;
			sortType.SelectedIndex = 0;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			labelMain.Text = "Gợi ý cho bạn";
			IsShowBXH = false;
			sortBy.Enabled = false;
			filterBuilder = filterBuilder.SortBy(SortBy.Recommend);
			var result = BookService.GetInstance()
				.Filter(filterBuilder.Build()).Select(m => m.ToDTO()).ToList();
			form.LoadBooks(result);
		}

		private void btnRanking_Click(object sender, EventArgs e)
		{
			IsShowBXH = true;
			filterBuilder = filterBuilder.SortType(SortType.Descending)
										.SortBy(SortBy.ViewCount) ;
			var result = BookService.GetInstance()
				.Filter(filterBuilder.Build()).Select(m => m.ToDTO()).ToList();
			form.LoadBooks(result);
			labelMain.Text = "Top xem nhiều";
			sortBy.Enabled = true;
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			labelMain.Text = "Đang đọc";
			IsShowBXH = false;
			sortBy.Enabled = false;
			filterBuilder = filterBuilder.SortBy(SortBy.Reading);
			var result = BookService.GetInstance()
				.Filter(filterBuilder.Build()).Select(m => m.ToDTO()).ToList();
			form.LoadBooks(result);
		}

		private void sortBy_SelectedValueChanged(object sender, EventArgs e)
		{
			int z = (int)sortBy.SelectedIndex;
			if (z < 0) return;
			switch (z)
			{
				//Theo luot xem
				case 0:
					{
						filterBuilder = filterBuilder.SortBy(SortBy.ViewCount);
						labelMain.Text = "Top xem nhiều";
						break;
					}
				//Theo danh gia
				case 1:
					{
						filterBuilder = filterBuilder.SortBy(SortBy.Star);
						labelMain.Text = "Top sách hay";
						break;
					}
			}
			var result = BookService.GetInstance().Filter(filterBuilder.Build()).Select(m => m.ToDTO()).ToList();
			form.LoadBooks(result);
		}

		private void sortType_SelectedValueChanged(object sender, EventArgs e)
		{
			int z = (int)sortType.SelectedIndex;
			if (z < 0) return;
			switch (z)
			{
				//Tang dan
				case 0:
					{
						filterBuilder = filterBuilder.SortType(SortType.Ascending);
						break;
					}
				//Giam dan
				case 1:
					{
						filterBuilder = filterBuilder.SortType(SortType.Descending);
						break;
					}
			}
			var result = BookService.GetInstance().Filter(filterBuilder.Build()).Select(m => m.ToDTO()).ToList();
			form.LoadBooks(result);
		}

		public void Reload()
		{
			var result = BookService.GetInstance().Filter(filterBuilder.Build()).Select(m => m.ToDTO()).ToList();
			form.LoadBooks(result);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			labelMain.Text = "Yêu thích";
			IsShowBXH = false;
			sortBy.Enabled = false;
			filterBuilder = filterBuilder.SortBy(SortBy.Favorite);
			var result = BookService.GetInstance()
				.Filter(filterBuilder.Build()).Select(m => m.ToDTO()).ToList();
			form.LoadBooks(result);
		}
	}
}
