using Application.Features.Background.Command;
using MediatR;
using Microsoft.Extensions.Hosting;

namespace Infrastructure;


    public class BgService : BackgroundService
    {
        private readonly IMediator _mediator;

        public BgService(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // Your background processing logic here
                await Task.Delay(TimeSpan.FromSeconds(1), stoppingToken); // Example delay

                // Perform a background action by sending a command through MediatR
                await _mediator.Send(new YourBackgroundCommand(), stoppingToken);
            }
        }
    }
