using AutoMapper;
using univesp_webapi.Data.DTO.Turmas;
using univesp_webapi.Models;

namespace univesp_webapi.Mapper
{
    public class TurmaMapper : Profile
    {
        public TurmaMapper()
        {
            CreateMap<Turma, GetTurmaDTO>();
        }
    }
}
