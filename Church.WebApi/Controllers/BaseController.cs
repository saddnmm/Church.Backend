using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Church.WebApi.Controllers
{
    [ApiController]
    [Route("api/[conteoller]/[action]")]
    public abstract class BaseController : ControllerBase
    {
        private IMediator _mediator;

        //  Формирование комманд
        protected IMediator Mediator =>
            _mediator ?? HttpContext.RequestServices.GetService<IMediator>();

        //  Id Служащего
        internal Guid Employee_id => !User.Identity.IsAuthenticated
            ? Guid.Empty
            : Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
    }
}
