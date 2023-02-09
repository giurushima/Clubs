using AutoMapper;
using Clubs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Clubs.Models;

namespace Clubs.Controllers
{
    [Route("api/clubs")]
    [ApiController]
    public class ClubsController : ControllerBase
    {
        private readonly IInfoClubsRepository _infoClubsRepository;
        private readonly IMapper _mapper;

        public ClubsController(IInfoClubsRepository IInfoClubsRepository, IMapper mapper)
        {
            _infoClubsRepository = IInfoClubsRepository;
            _mapper = mapper;
        }

    }
}
