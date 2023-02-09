using AutoMapper;
using Clubs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clubs.Controllers
{
    [Route("api/players")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IInfoClubsRepository _infoClubsRepository;
        private readonly IMapper _mapper;

        public PlayersController(IInfoClubsRepository IInfoClubsRepository, IMapper mapper)
        {
            _infoClubsRepository = IInfoClubsRepository;
            _mapper = mapper;
        }
    }
}
