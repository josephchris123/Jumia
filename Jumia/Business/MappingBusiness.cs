using Jumia.Models;
using Jumia.Models.DTO;
using AutoMapper;
namespace Jumia.Business
{
    public class MappingBusiness : Profile
    {
        public MappingBusiness()
        {
            CreateMap<User, UserDto>().ReverseMap();

        }
    }
}
