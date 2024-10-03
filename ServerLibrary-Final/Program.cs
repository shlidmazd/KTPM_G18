using Microsoft.Extensions.Configuration;
using ServerLibrary.Models;
using ServerLibrary.Repository;
using ServerLibrary.Services;
using ServerLibrary.Utils;
using ServerLibrary.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerLibrary
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			LibraryContext.gI();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormLogin());
		}
	}
}
