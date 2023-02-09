using AutoMapper;

namespace Clubs.AutoMapperProfiles
{
    public class ClubProfile : Profile
    {
        //06-01 hago un constructor
        public ClubProfile()
        {
            //acá mapeo los Dto de Club (Club sin movie y Club, se llama a Models, no a models como en la diapositiva)
            CreateMap<Entities.Club, Models.PlayerWithOutClubsDto>();//esto dice te puedo pedir que mapees desde Club
                                                                     //hasta ClubSinMovieDto
            CreateMap<Entities.Club, Models.ClubDto>();

            //creation
            CreateMap<Models.ClubToCreateDto, Entities.Club>();
            CreateMap<Entities.Club, Models.ClubToCreateDto>();
            
            //update
            CreateMap<Models.ClubToUpdateDto, Entities.Club>();
            CreateMap<Entities.Club, Models.ClubToUpdateDto>();

        }
    }
}
