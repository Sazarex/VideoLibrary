using AutoMapper;
using Domain;
using WinFormsVideoLibrary.Dto;

namespace WinFormsVideoLibrary.AutoMapperProfiles
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<Movie, MovieListDto>()
                .ForMember(dest => dest.GenreName, opt => opt.MapFrom(src => src.Genre.Name));

            CreateMap<Movie, MovieListDto>()
                .ForMember(dest => dest.ProducerName, opt => opt.MapFrom(src => src.Producer.Name));



            CreateMap<Movie, MovieEntityDto>()
                .ForMember(dest => dest.ProducerName, opt => opt.MapFrom(src => src.Producer.Name));

            CreateMap<Movie, MovieListDto>()
                .ForMember(dest => dest.GenreName, opt => opt.MapFrom(src => src.Genre.Name));



            CreateMap<User, UsersListDto>()
                .ForMember(
                    dest => dest.IsSubscriptionActive,
                    opt => opt.MapFrom(src => IsSubscriptionActive(src.Subscription))
                );
        }

        private static string IsSubscriptionActive(Subscription subscription)
        {
            var isActive = "Активна";
            var isNotActive = "Неактивна";

            if (subscription == null)
            {
                return isNotActive;
            }

            DateTime now = DateTime.Now;
            return subscription.CreationDate.GetValueOrDefault() < now && subscription.EndDate.GetValueOrDefault() > now ? isActive : isNotActive;
        }
    }
}
