using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ChessMates.DTOs;
using ChessMates.Models;

namespace ChessMates.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Tournament, TournamentDTO>();
            Mapper.CreateMap<TournamentDTO, Tournament>();
        }
    }
}