using AutoMapper;
using Church.Application.Church.Commands.CreateEmployee;
using Church.Application.Common.Mapping;

namespace Church.WebApi.Models
{
    public class CreateEmployeeDto : IMapWith<CreateEmployeeCommand>
    {
        public Guid Employee_id {  get; set; }
        public string Employee_name { get; set; }

        public string Employee_surname { get; set; }

        public string Employee_patronymic { get; set; }

        public string Employee_email { get; set; }

        public string Employee_phone { get; set; }

        public string Employee_description_about { get; set; }

        public Guid Employee_role_Id { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateEmployeeDto, CreateEmployeeCommand>()
                .ForMember(x => x.Employee_name,
                    opt => opt.MapFrom(d => d.Employee_name))
                .ForMember(x => x.Employee_surname,
                    opt => opt.MapFrom(d => d.Employee_surname))
                .ForMember(x => x.Employee_patronymic,
                    opt => opt.MapFrom(d => d.Employee_patronymic))
                .ForMember(x => x.Employee_email,
                    opt => opt.MapFrom(d => d.Employee_email))
                .ForMember(x => x.Employee_phone,
                    opt => opt.MapFrom(d => d.Employee_phone))
                .ForMember(x => x.Employee_description_about,
                    opt => opt.MapFrom(d => d.Employee_description_about))
                .ForMember(x => x.Employee_role_Id,
                    opt => opt.MapFrom(d => d.Employee_role_Id));
        }
    }
}
