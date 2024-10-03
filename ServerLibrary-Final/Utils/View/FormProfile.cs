using ServerLibrary.State;
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
	public partial class FormProfile : Form
	{
		private Form FormParent;
		public FormProfile(Form parent)
		{
			this.FormParent = parent;
			InitializeComponent();
		}

		private void FormProfile_Load(object sender, EventArgs e)
		{
			var user = AppState.Instance.User;
			txtHoTen.Text = user.Username;
			txtDiaChi.Text = user.Address;
			txtNgaySinh.Text = user.Birth.ToString();
			txtUsername.Text = user.Username;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormParent.Show();
			this.Dispose();
		}

		private void FormProfile_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
