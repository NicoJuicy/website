using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Momentum.Auth.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private IMediator m_mediator;

        public AuthController(IMediator mediator, ILogger<AuthController> logger)
        {
            _logger = logger;
            m_mediator = mediator;
        }

        [HttpGet("steam/return")]
        public async Task GetSteamRedirect()
        {
            return 
        }
    }
}
