using Domain.Commands;
using CQRS_sem_mediatr.CommandsHandlers;
using Domain.Queries;
using CQRS_sem_mediatr.QueriesHandlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_sem_mediatr.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        private readonly AddOrderCommandHandler _commandHandler;
        private readonly GetOrderQueryHandler _queryHandler;

        public OrderController(
            ILogger<OrderController> logger,
            AddOrderCommandHandler commandHandler,
            GetOrderQueryHandler queryHandler)
        {
            _logger = logger;
            _commandHandler = commandHandler;
            _queryHandler = queryHandler;
        }

        [HttpPut]
        [Route("get")]
        public async Task<IActionResult> Get(
            GetOrderQuery query,
            CancellationToken cancellationToken)
        {
            try
            {
                var result = await _queryHandler
                    .Handle(query, cancellationToken);

                if (result.IsSuccess)
                    return Ok(result);

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Post(
            AddOrderCommand command,
            CancellationToken cancellationToken)
        {
            try
            {
                var result = await _commandHandler
                    .Handle(command, cancellationToken);

                if (result.IsSuccess)
                    return Ok(result);

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
