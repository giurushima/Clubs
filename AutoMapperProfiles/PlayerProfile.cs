namespace Clubs.AutoMapperProfiles
{
    public class PlayerProfile : AutoMapper.Profile //en vez de agregar el using AutoMapper también se puede hacer así
    {
        public PlayerProfile()
        {
            //mapeo de entidad a Dto
            CreateMap<Entities.Player, Models.PlayerDto>();
            //mapeo de Dto a entidad 
            CreateMap<Models.PlayerDto, Entities.Player>();

            //para que funcione el HttpPost y mapee de Dto de creación a entidad hay que agregar esto de abajo
            //agregar el Dto de creación
            //no funcionaba porque no había mapeado PlayerToCreationDto a Entities.Player 06-01 ,minuto 50
            CreateMap<Models.PlayerToCreateDto, Entities.Player>();
            //no funcionaba porque no había mapeado PlayerToUpdateDto a Entities.Player 06-01 ,minuto 50
            CreateMap<Models.PlayerToUpdateDto, Entities.Player>();
        }
    }
}
