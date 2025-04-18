//How to use inside your project with Logging

private readonly ILogger<MyService> _logger;

public MyService(ILogger<MyService> logger)
{
    _logger = logger;
}

public void DoSomething()
{
    _logger.LogInformation("Đang xử lý gì đó...");
}