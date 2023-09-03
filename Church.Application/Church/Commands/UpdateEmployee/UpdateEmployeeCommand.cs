using MediatR;

namespace Church.Application.Church.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommand : IRequest<Unit>
    {
        public Guid Employee_id { get; set; }

        public string Employee_name { get; set; }

        public string Employee_surname { get; set; }

        public string Employee_patronymic { get; set; }

        public string Employee_email { get; set; }

        public string Employee_phone { get; set; }

        public string Employee_description_about { get; set; }

        public int Employee_role_Id { get; set; }

    }
}
