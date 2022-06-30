using AutoMapper;
using univesp_webapi.Data.DTO.Professores;
using univesp_webapi.Models;

namespace univesp_webapi.Mapper
{
    public class ProfessorMapper : Profile
    {
        public ProfessorMapper()
        {
            CreateMap<Professor, GetprofessoresDTO>();
            
        }
    }
}
