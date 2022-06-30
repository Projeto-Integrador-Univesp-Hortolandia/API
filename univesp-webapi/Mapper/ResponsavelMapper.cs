using AutoMapper;
using univesp_webapi.Data.DTO.Responsavel;
using univesp_webapi.Models;

namespace univesp_webapi.Mapper
{
    public class ResponsavelMapper : Profile
    {
        public ResponsavelMapper()
        {
            CreateMap<Responsavel, GetResponsavelDTO>();            
        }
    }
}
