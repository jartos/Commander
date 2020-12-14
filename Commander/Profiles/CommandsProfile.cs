using AutoMapper;
using Commander.DTOs;
using Commander.Models;

namespace Commander.Profiles
{                                //Automapper
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // From source object to destination object
            CreateMap<Command, CommandReadDto>();

            // Updated DTO from client, appliend to Command object retrieved from repository
            CreateMap<CommandCreateDto, Command>();

            CreateMap<CommandUpdateDto, Command>();

            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
