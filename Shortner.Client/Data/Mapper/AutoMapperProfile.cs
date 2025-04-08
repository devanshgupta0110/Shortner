using AutoMapper;
using Shortner.Client.Data.ViewModels;
using Shortner.Data.Models;

namespace Shortner.Client.Data.Mapper
{
	public class AutoMapperProfile: Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<Url, GetUrlVM>().ReverseMap();
			CreateMap<AppUser, GetUserVM>().ReverseMap();
		}
	}
}
