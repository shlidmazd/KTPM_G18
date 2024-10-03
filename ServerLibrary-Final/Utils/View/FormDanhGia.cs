using ServerLibrary.DTOs;
using ServerLibrary.Entities;
using ServerLibrary.Extensions;
using ServerLibrary.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerLibrary.View
{
	public partial class FormDanhGia : Form
	{
		private BookDTO book;
		private int Index = 0;
		private List<RateDTO> rates;
		public FormDanhGia(BookDTO book)
		{
			this.book = book;
			rates = book.Rates;
			InitializeComponent();
			Reload();
		}

		public void Reload()
		{
			List<RateDTO> _rates = RateService.Instance.Where(m => m.IdBook == book.Id).GetRatesDTO().ToList();
			rates = _rates;
			if (book != null)
			{
				if(rates == null || rates.Count() == 0 )
				{
					VisibleElement(false);
					return;
				}
				LoadRate(rates[0],Index);
			}
		}
		private void VisibleElement(bool visible)
		{
			lbName.Visible = visible;
			lbStar.Visible = visible;
			lbUsername.Visible = visible;
			tbContent.Visible = visible;
			paging.Visible = visible;
			pictureBox1.Visible = visible;
			prev.Visible = visible;
			next.Visible = visible;
			pictureBox2.Visible = visible;
		}
		private void LoadRate(RateDTO rate, int index)
		{
			lbName.Text = rate.FullName;
			lbStar.Text = rate.Star.ToString();
			lbUsername.Text = rate.Username.ToString();
			tbContent.Text = rate.ContentRate;
			paging.Text = $"{index + 1}/{rates.Count()}";
			VisibleElement(true);
		}

		private void next_Click(object sender, EventArgs e)
		{
			if(this.rates.Count > 0)
			{
				Index++;
				if(Index == rates.Count)
				{
					Index = 0;
				}
				LoadRate(rates[Index], Index);
			}
		}

		private void prev_Click(object sender, EventArgs e)
		{
			if (this.rates.Count > 0)
			{
				Index--;
				if (Index < 0)
				{
					Index = rates.Count - 1;
				}
				LoadRate(rates[Index], Index);
			}
		}

		private void FormDanhGia_Load(object sender, EventArgs e)
		{

		}
	}
}
