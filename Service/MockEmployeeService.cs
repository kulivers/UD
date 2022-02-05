using Contracts;
using LoggerService;
using ServiceContracts;

namespace Service;

internal sealed class MockEmployeeService : IMockEmployeeService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public MockEmployeeService(IRepositoryManager repository, ILoggerManager
        logger)
    {
        _repository = repository;
        _logger = logger;
    }
}