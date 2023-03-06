﻿using AutoMapper;
using Clubs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Clubs.Models;
using Clubs.Entities;

namespace Clubs.Controllers
{
    [Route("api/clubs")]
    [ApiController]
    [Authorize]
    public class ClubsController : ControllerBase
    {
        private readonly IInfoClubsRepository _infoClubsRepository;
        private readonly IMapper _mapper;
         
        public ClubsController(IInfoClubsRepository IInfoClubsRepository, IMapper mapper)
        {
            _infoClubsRepository = IInfoClubsRepository;
            _mapper = mapper;
        }
        [HttpGet]
        //el famoso GetAll
        public JsonResult GetClubs()
        {
            
            var clubs = _infoClubsRepository.GetClubs();

            return new JsonResult(_mapper.Map<ICollection<ClubDto>>(clubs));

            //buscar Clubes con la instancia y pasarlo como parámetro (esto se hacía antes de la inyecíón de dependencia)

        }
        [HttpGet("{idClub}")]
        public IActionResult GetClub(int idClub)
        {
            Entities.Club? club = _infoClubsRepository.GetClub(idClub);
            if (club is null)
            {
                return NotFound();
            }
            
            return Ok(_mapper.Map<ClubDto>(club));   
        }
        [HttpPost(Name = "GetClubs")]
        public ActionResult<ClubDto> AgregarClub(int idClub,ClubToCreateDto ClubToCreate)
        {
            Club club = _mapper.Map<Club>(ClubToCreate);

            _infoClubsRepository.AgregarClub(club);

            _infoClubsRepository.GuardarCambios();


            return CreatedAtRoute(
                        "GetClubs",
                        new
                        {
                            idClub = club.Id

                        },
                        _mapper.Map<ClubDto>(club));
        }

    }
}
