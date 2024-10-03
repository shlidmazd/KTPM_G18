using ServerLibrary.Entities;
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
	public partial class FormDangKy : Form
	{
		private Form FormParent;
		public FormDangKy(Form ParentForm)
		{
			InitializeComponent();
			this.FormParent = ParentForm;
		}

		private void FormDangKy_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormParent.Show();
			this.Dispose();
		}

		private void btnDangKy_Click(object sender, EventArgs e)
		{
			string username = txtTaiKhoan.Text;
			string password = txtMatKhau.Text;
			string hoten = txtHoTen.Text;
			string diachi = txtDiaChi.Text;
			DateTime ngaySinh = dateTime.Value;
			bool isValid = StringUtil.ValidateString(username) && StringUtil.ValidateString(password);
			if (!isValid)
			{
				GuiUtil.ShowError("Tài khoản và mật khẩu chỉ được chứa a-z A-z và 0-9!");
				return;
			}
			var user = new User()
			{
				Address = diachi,
				Birth = ngaySinh,
				FullName = hoten,
				Password = password,
				Username = username,
			};
			bool result = UserService.GetInstance().Register(user) != null;
			if(result)
			{
				GuiUtil.ShowSuccess("Đăng ký thành công !");
			}
			else
			{
				GuiUtil.ShowError("Tài khoản đã có người đăng ký");
			}
		}

		private void FormDangKy_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
