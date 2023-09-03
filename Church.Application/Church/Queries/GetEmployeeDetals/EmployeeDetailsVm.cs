using AutoMapper;
using Church.Application.Common.Mapping;
using Church.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Application.Church.Queries.GetEmployeeDetals
{
    public class EmployeeDetailsVm : IMapWith<Tbemployee>
    {
        public Guid Employee_id { get; set; }
        public string Employee_name { get; set; }
        public string Employee_surname { get; set; }
        public string Employee_patronymic { get; set; }
        public string Employee_email { get; set; }
        public string Employee_phone { get; set; }
        public string Employee_description_about { get; set; }
        public int Employee_role_Id { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Tbemployee, EmployeeDetailsVm>()
                .ForMember(employeeVm => employeeVm.Employee_name,
                    opt => opt.MapFrom(employee => employee.Employee_name))
                .ForMember(employeeVm => employeeVm.Employee_surname,
                    opt => opt.MapFrom(employee => employee.Employee_surname))
                .ForMember(employeeVm => employeeVm.Employee_patronymic,
                    opt => opt.MapFrom(employee => employee.Employee_patronymic))
                .ForMember(employeeVm => employeeVm.Employee_email,
                    opt => opt.MapFrom(employee => employee.Employee_email))
                .ForMember(employeeVm => employeeVm.Employee_description_about,
                    opt => opt.MapFrom(employee => employee.Employee_description_about))
                .ForMember(employeeVm => employeeVm.Employee_role_Id,
                    opt => opt.MapFrom(employee => employee.Employee_role_Id));
        }
    }
}
