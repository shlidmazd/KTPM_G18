using ServerLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerLibrary.View
{
	public partial class FormDocSach : Form
	{
		private int Page = 1;
		private BookDTO book;
		private Form FormParent;
		public FormDocSach(BookDTO book, Form FormParent)
		{
			this.book = book;
			this.FormParent = FormParent;
			InitializeComponent();
			LoadPage();
		}

		private void FormDocSach_Load(object sender, EventArgs e)
		{
			this.lbPage.Text = $"{Page}/{book.EndChapter}";
		}

		private void btnLeft_Click(object sender, EventArgs e)
		{
			Page = Page - 1 < 1 ? book.EndChapter : Page - 1;
			LoadPage();
		}

		private void btnRight_Click(object sender, EventArgs e)
		{
			Page = Page + 1 > book.EndChapter ? 1 : Page + 1;
			LoadPage();
		}

		private void LoadPage()
		{
			this.lbPage.Text = $"{Page}/{book.EndChapter}";
			string url = $"http://127.0.0.1/Books/Contents/{book.ChapterFolder}/{Page}.jpg";
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = "GET";

			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			{
				// Kiểm tra mã trạng thái và Content-Type để đảm bảo là hình ảnh
				if (response.StatusCode == HttpStatusCode.OK && response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
				{
					using (Stream stream = response.GetResponseStream())
					{
						if (stream != null)
						{
							pictureBox1.Image = System.Drawing.Image.FromStream(stream);
						}
					}
				}
				else
				{
					MessageBox.Show("Dữ liệu không phải là hình ảnh hoặc không thể tải được.");
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormParent.Show();
			this.Dispose();
		}

		private void FormDocSach_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
