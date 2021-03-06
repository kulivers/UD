using Contracts;
using LoggerService;
using ServiceContracts;

namespace Service;

public class CompanyService : ICompanyService
{
    private readonly ILoggerManager _loggerManager;
    private readonly IRepositoryManager _repositoryManager;

    public CompanyService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
    {
        _loggerManager = loggerManager;
        _repositoryManager = repositoryManager;
    }
}