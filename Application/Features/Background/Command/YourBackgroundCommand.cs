using MediatR;

namespace Application.Features.Background.Command;

public class YourBackgroundCommand : IRequest
{
    // Any properties or information needed for the background task can be added here
}

public class YourBackgroundCommandHandler : IRequestHandler<YourBackgroundCommand>
{
    // Implement the handler for the background command
    public Task Handle(YourBackgroundCommand request, CancellationToken cancellationToken)
    {
        // Implement the logic for the background command here
        // This logic will be executed when the BackgroundService sends this command

        // Example: Log the background operation
        Console.WriteLine("Background task executed!");

        return Task.FromResult(Unit.Value);
    }
}