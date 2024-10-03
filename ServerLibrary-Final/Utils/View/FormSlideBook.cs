using ServerLibrary.DTOs;
using ServerLibrary.Services;
using ServerLibrary.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerLibrary.View
{
	public partial class FormSlideBook : Form
	{
		private List<BookDTO> books;
		private int Index = 0;
		private Dashboard MasterForm;
		public FormSlideBook(List<BookDTO> books, Dashboard MasterForm)
		{
			this.MasterForm = MasterForm;
			this.books = books;
			InitializeComponent();
			LoadBooks();
		}

		public FormSlideBook(Dashboard MasterForm) 
		{
			this.MasterForm = MasterForm;
			InitializeComponent(); 
		}

		private void FormSlideBook_Load(object sender, EventArgs e)
		{
			
		}
		public void LoadBooks(List<BookDTO> books)
		{
			this.books = books;
			LoadBooks();
		}
		public void LoadBooks()
		{
			Index = 0;
			this.idx.Text = "0";
			if (this.books.Count > 0)
			{
				btnXemChiTiet.Visible = true;
				this.sizeBook.Text = this.books.Count.ToString();
				this.idx.Text = "1";
				LoadBook(this.books[0]);
				VisibleElement(true);
			}
			else
			{
				VisibleElement(false);
			}
		}
		private void VisibleElement(bool visible)
		{
			label1.Visible = visible;
			label2.Visible = visible;
			label3.Visible = visible;
			label9.Visible = visible;
			labelLuotXem.Visible = visible;
			labelStar.Visible = visible;
			labelTacGia.Visible = visible;
			labelTenSach.Visible = visible;
			pictureBox1.Visible = visible;
			ImageBox.Visible = visible;
			btnLeft.Visible = visible;
			btnRight.Visible = visible;
			btnXemChiTiet.Visible = visible;
			idx.Visible = visible;
			sizeBook.Visible = visible;
			tvx.Visible = visible;
		}
		public void LoadBook(BookDTO book)
		{
			if(book != null)
			{
				try
				{
					labelLuotXem.Text = book.ViewCount.ToString();
					labelStar.Text = Math.Round(book.Rate, 1).ToString();
					labelTacGia.Text = book.Author.ToString();
					labelTenSach.Text = book.Title.ToString();
					HttpWebRequest request = (HttpWebRequest)WebRequest.Create(book.Image);
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
									ImageBox.Image = System.Drawing.Image.FromStream(stream);
								}
							}
						}
						else
						{
							MessageBox.Show("Dữ liệu không phải là hình ảnh hoặc không thể tải được.");
						}
					}
				}
				catch(Exception ex)
				{
					GuiUtil.ShowError("[Ex] " +ex.Message);
				}
			}
		}

		private void btnLeft_Click(object sender, EventArgs e)
		{
			if(this.books.Count > 0)
			{
				
				Index--;
				if (Index < 0)
				{
					Index = this.books.Count - 1;
				}
				LoadBook(this.books[Index]);
				idx.Text = (Index+1).ToString();
			}
			else
			{
			}
		}

		private void btnRight_Click(object sender, EventArgs e)
		{
			if (this.books.Count > 0)
			{
				Index++;
				if (Index > this.books.Count - 1)
				{
					Index = 0;
				}
				LoadBook(this.books[Index]);
				idx.Text = (Index + 1).ToString();
			}
		}

		private void ImageBox_Click(object sender, EventArgs e)
		{

		}

		private void btnXemChiTiet_Click(object sender, EventArgs e)
		{
			try
			{
				BookService.GetInstance().IncreaseView(this.books[Index].Id);
				new FormChiTietSach(this.books[Index], MasterForm).Show();
				MasterForm.Hide();
			}
			catch
			{

			}
		}
	}
}
