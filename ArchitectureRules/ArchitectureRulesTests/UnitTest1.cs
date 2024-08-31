using ArchitectureRules.Interfaces;
using NetArchTest.Rules;

namespace ArchitectureRulesTests;

public class UnitTest1
{
    [Fact(DisplayName = "Classes implementing IRequest should be named with Request Suffix")]
    public void IRequest_Implementations_Should_Have_Request_Suffix()
    {
        var result = Types
            //.InAssembly(ApplicationAssembly)
            .InNamespace("ArchitectureRules")
            .That()
            .ImplementInterface(typeof(IRequest))
            .Should()
            .HaveNameEndingWith("Request")
            .GetResult();

        Assert.True(result.IsSuccessful, $"Failed Implementations: \n{ToAssertMessage(result.FailingTypeNames)}");
    }
    
    [Fact(DisplayName = "Classes implementing IRequestHandler should be named with RequestHandler Suffix")]
    public void IRequestHandler_Implementations_Should_Have_QueryHandler_Suffix()
    {
        var result = Types
            .InNamespace("ArchitectureRules")
            .That()
            .ImplementInterface(typeof(IRequestHandler<,>))
            .Should()
            .HaveNameEndingWith("RequestHandler")
            .GetResult();

        Assert.True(result.IsSuccessful, $"Failed Implementations: \n{ToAssertMessage(result.FailingTypeNames)}");
    }
    
    [Fact(DisplayName = "Classes implementing ICommandHandler should be named with CommandHandler Suffix")]
    public void ICommandHandler_Implementations_Should_Have_CommandHandler_Suffix()
    {
        var result = Types
            .InNamespace("ArchitectureRules")
            .That()
            .ImplementInterface(typeof(ICommandHandler<>))
            .Should()
            .HaveNameEndingWith("CommandHandler")
            .GetResult();

        Assert.True(result.IsSuccessful, $"Failed Implementations: \n{ToAssertMessage(result.FailingTypeNames)}");
    }
    
    [Fact(DisplayName = "Classes implementing ICommand should be named with Command Suffix")]
    public void ICommand_Implementations_Should_Have_Command_Suffix()
    {
        var result = Types
            .InNamespace("ArchitectureRules")
            .That()
            .ImplementInterface(typeof(ICommand))
            .Should()
            .HaveNameEndingWith("Command")
            .GetResult();

        Assert.True(result.IsSuccessful, $"Failed Implementations: \n{ToAssertMessage(result.FailingTypeNames)}");
    }

    private string ToAssertMessage(IReadOnlyList<string> failingTypes)
        => failingTypes is null ? string.Empty : string.Join('\n', failingTypes);
}