using ServerLibrary.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerLibrary.Services;
using ServerLibrary.Utils;
using ServerLibrary.State;

namespace ServerLibrary
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			bool isValid = ValidateUtil.IsOnlyTextAndNumber(username) && ValidateUtil.IsOnlyTextAndNumber(password);
			if(!isValid)
			{
				MessageBox.Show("Định dạng tài khoản hoặc mật khẩu không hợp lệ !");
				return;
			}
			var user = UserService.GetInstance().Login(username, password);
			if(user != null)
			{
				AppState.Instance.User = user;
				GuiUtil.ShowSuccess("Đăng nhập thành công !");
				new Dashboard().Show();
				this.Hide();
			}
			else
			{
				GuiUtil.ShowError("Tài khoản hoặc mật khẩu không chính xác");
				return;
			}
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			new FormDangKy(this).Show();
			this.Hide();
		}

		private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			
		}

		private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
