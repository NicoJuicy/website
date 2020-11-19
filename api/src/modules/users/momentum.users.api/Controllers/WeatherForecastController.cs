using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using momentum.framework.core.Services;

namespace Momentum.Users.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private IUserService m_userService;
        private IMediator m_mediator;

        public WeatherForecastController(IUserService userService, IMediator mediator, ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            m_userService = userService;
            m_mediator = mediator;

        }


        [HttpGet]
        public async Task<object> GetUserProfile()
        {
            var currentUser = await m_userService.GetCurrentUser();

            var request = new Application.Handlers.Queries.GetProfileByUserId()
            {
                UserId = currentUser.UserId
            };

            var response = m_mediator.Send(request);

        }
    }
}
