using MediatR;

namespace app.Behaviors;

public class LoginBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly ILogger<LoginBehavior<TRequest, TResponse>> _logger;
    
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Handling {typeof(TRequest).Name}");
        
        var response = await next();
        
        _logger.LogInformation($"Handled: {typeof(TResponse).Name}");
        
        return response;
    }
}