using ServerLibrary.DTOs;
using ServerLibrary.Entities;
using ServerLibrary.Services;
using ServerLibrary.State;
using ServerLibrary.Utils;
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
	public partial class FormChiTietSach : Form
	{
		private Dashboard FormParent;
		private BookDTO book;
		private FormDanhGia formDanhGia;
		public FormChiTietSach(BookDTO book, Dashboard parent)
		{
			this.FormParent = parent;
			this.book = book;
			InitializeComponent();
			formDanhGia = new FormDanhGia(book);
			formDanhGia.TopLevel = false;
			panelDanhGia.Controls.Clear();
			panelDanhGia.Controls.Add(formDanhGia);
			formDanhGia.Show();
			load();
		}

		private void load()
		{
			if (book != null)
			{
				try
				{
					lbLuotXem.Text = book.ViewCount.ToString();
					lbStar.Text = Math.Round(book.Rate, 1).ToString();
					lbTacGia.Text = book.Author.ToString();
					lbTenSach.Text = book.Title.ToString();
					tbTheLoai.Text = book.Tag.ToString();
					tbTomTat.Text = book.Description.ToString();
					btnYeuThich.Image = book.IsFavorite ? ServerLibrary.Properties.Resources.heart_full : ServerLibrary.Properties.Resources.heart_empty;
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
				catch (Exception ex)
				{
					GuiUtil.ShowError("[Ex] " + ex.Message);
				}
			}
		}

		private void FormChiTietSach_Load(object sender, EventArgs e)
		{
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormParent.Reload();
			FormParent.Show();
			this.Dispose();
		}

		private void btnYeuThich_Click(object sender, EventArgs e)
		{
			bool result = ReadStatusService.GetInstance().MarkFavorite(book.Id, AppState.Instance.User);
			btnYeuThich.Image = result ? ServerLibrary.Properties.Resources.heart_full : ServerLibrary.Properties.Resources.heart_empty;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ReadStatusService.GetInstance().MarkReading(book.Id, AppState.Instance.User);
			new FormDocSach(book, this).Show();
			this.Hide();
		}

		private void btnNhanXet_Click(object sender, EventArgs e)
		{
			var nhanxet = txtNhanXet.Text;
			if (string.IsNullOrEmpty(nhanxet))
			{
				GuiUtil.ShowError("Không được để trống lời nhận xét !");
				return;
			}
			byte star = (byte)numberStar.Value;
			Rate rate = new Rate()
			{
				ContentRate = nhanxet,
				IdBook = book.Id,
				IdUser = AppState.Instance.User.Id,
				Star = star
			};
			bool rateSuccess = RateService.Instance.RateBook(rate);
			if(!rateSuccess)
			{
				GuiUtil.ShowError("Bạn đã đánh giá rồi !");
			}
			else
			{
				txtNhanXet.Clear();
				formDanhGia.Reload();
				lbStar.Text = Math.Round(RateService.Instance.GetRate(book.Id),1).ToString();
				GuiUtil.ShowSuccess("Cảm ơn bạn đã để lại nhận xét!");
			}
		}

		private void FormChiTietSach_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
