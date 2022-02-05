using Contracts;
using LoggerService;
using ServiceContracts;

namespace Service;

internal sealed class MockCompanyService : IMockCompanyService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public MockCompanyService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }
}