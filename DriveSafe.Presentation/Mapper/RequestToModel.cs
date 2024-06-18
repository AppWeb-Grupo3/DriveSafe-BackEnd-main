using AutoMapper;
using DriveSafe.Domain.Publishing.Models.Commands;
using DriveSafe.Domain.Publishing.Models.Entities;
using DriveSafe.Domain.Security.Models.Commands;

namespace DriveSafe.Presentation.Mapper;

public class RequestToModel : Profile
{
    public RequestToModel()
    {
        CreateMap<SignUpCommand, User>();
        CreateMap<UpdateUserCommand, User>();
    }
}