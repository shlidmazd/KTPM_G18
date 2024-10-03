using ServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerLibrary.Utils
{
	internal class GuiUtil
	{
		public static void ShowError(string message)
		{
			MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public static void ShowSuccess(string message)
		{
			MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		public static void ShowInfo(string message)
		{
			MessageBox.Show(message, "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
