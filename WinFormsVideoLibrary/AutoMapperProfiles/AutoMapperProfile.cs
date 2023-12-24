using AutoMapper;
using Domain;
using WinFormsVideoLibrary.Dto;

namespace WinFormsVideoLibrary.AutoMapperProfiles
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<Movie, MovieDto>()
                .ForMember(dest => dest.GenreName, opt => opt.MapFrom(src => src.Genre.Name));

            CreateMap<Movie, MovieDto>()
                .ForMember(dest => dest.ProducerName, opt => opt.MapFrom(src => src.Producer.Name));
        }
    }
}
