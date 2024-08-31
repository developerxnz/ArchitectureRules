using ArchitectureRules.Interfaces;

namespace ArchitectureRules.Implementations;

/// <summary>
/// Valid Named Classes
/// </summary>
public sealed record ValidNameRequest : IRequest;

public sealed record ValidNameResponse : IResponse;

/// <summary>
/// Invalid Named Classes, will fail unit tests
/// </summary>
public sealed record InvalidRequestName : IRequest;

public sealed record InvalidResponseName : IResponse;

/// <summary>
/// Valid Named Class for IRequestHandler
/// </summary>
public sealed class ValidNameRequestHandler : IRequestHandler<ValidNameRequest, ValidNameResponse>
{
    public Task<ValidNameResponse> HandleAsync(ValidNameRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// Invalid Named Class for IRequestHandler, will fail unit tests
/// </summary>
public sealed class InvalidNameHandler : IRequestHandler<ValidNameRequest, ValidNameResponse>
{
    public Task<ValidNameResponse> HandleAsync(ValidNameRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

public sealed record ValidNameCommand : ICommand;

public class ValidNameCommandHandler : ICommandHandler<ValidNameCommand>
{
    public Task HandleAsync(ValidNameCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}