using AutoMapper;
using Clubs.Services;
using Clubs.Models;
using Clubs.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Clubs.Controllers
{
    [ApiController]
    [Route("api/clubs/{idClub}/players")]
    public class PlayersController : ControllerBase
    {
        private readonly IInfoClubsRepository _repository;
        private readonly IMapper _mapper;

        public PlayersController(IInfoClubsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet] //este es el GetAll obtener todo
        //esto es lo que va a devolver, hace una accion result que crea una lista de peliculas
        public ActionResult<List<PlayerDto>> GetPlayers(int idClub)//05-19 nota#4 
        {
            //nueva forma 06-01 min 29
            if (!_repository.ExisteClub(idClub))
                return NotFound();

            List<Entities.Player> players = _repository.GetPlayers(idClub).ToList();
            return Ok(_mapper.Map<List<PlayerDto>>(players));
        }

        //ahora el get por id se hace así desde el 06-01
        [HttpGet("{idPlayer}", Name = "GetPlayers")] //paso el id de la pelicula  *1 de acá se sacan los datos del post

        public ActionResult<PlayerDto> GetPlayers(int idClub, int idPlayer)
        {
            //pregunta con el nuevo método si existe idDrector
            if (!_repository.ExisteClub(idClub))
                return NotFound();
            //usa el método GetPlayer y le pasa el idClub y el IdPlayer
            Entities.Player? player = _repository.GetPlayer(idClub, idPlayer);

            if (player == null)
                return NotFound();
            return Ok(_mapper.Map<PlayerDto>(player));


            //esto no se hace más desde el 06-01
            //var director = _directoresData.Directores.Where(d => d.Id == idClub).FirstOrDefault();

            //if (director == null)
            //{
            //    return NotFound();
            //}
            ////si encontró al director creo la variale Player y le paso el IdPlayer del director que busqué antes, arriba
            ////if (director == null) ese director
            //var Player = director.Players.Where(d => d.Id == IdPlayer).FirstOrDefault();

            //if (Player == null)
            //{
            //    return NotFound();
            //}
            //return Ok(Player);

        }


    }

}
