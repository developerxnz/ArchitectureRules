namespace ArchitectureRules.Interfaces;

public interface IRequest;

public interface IResponse;

public interface IRequestHandler<in TRequest, TResponse>
    where TRequest : IRequest
    where TResponse : IResponse
{
    Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken);
}

public interface ICommand;

public interface ICommandHandler<in TCommand>
    where TCommand : ICommand
{
    Task HandleAsync(TCommand command, CancellationToken cancellationToken);
}