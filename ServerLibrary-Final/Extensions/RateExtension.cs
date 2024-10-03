using ServerLibrary.DTOs;
using ServerLibrary.Entities;
using ServerLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Extensions
{
	internal static class RateExtension
	{
		public static RateDTO ToDTO(this Rate rate)
		{
			var user = UserService.GetInstance().FirstOrDefault(u => u.Id == rate.IdUser);
			RateDTO dto = new RateDTO()
			{
				Rate = rate.ContentRate,
				Star = rate.Star,
				Username = user.Username,
				FullName = user.FullName,
				ContentRate = rate.ContentRate,
			};
			return dto;
		}
		public static IEnumerable<RateDTO> GetRatesDTO(this IEnumerable<Rate> rates)
		{
			List<RateDTO> rateDTOs = new List<RateDTO>();
			foreach (var rate in rates)
			{
				rateDTOs.Add(rate.ToDTO());
			}
			return rateDTOs;
		}
	}
}
