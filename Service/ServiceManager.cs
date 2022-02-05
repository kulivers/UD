using Contracts;
using LoggerService;
using ServiceContracts;

namespace Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IMockCompanyService> _mockcompanyService;
    private readonly Lazy<IMockEmployeeService> _mockemployeeService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager
        logger)
    {
        _mockcompanyService = new Lazy<IMockCompanyService>(() => new
            MockCompanyService(repositoryManager, logger));
        _mockemployeeService = new Lazy<IMockEmployeeService>(() => new
            MockEmployeeService(repositoryManager, logger));
    }

    public IMockCompanyService MockCompanyService => _mockcompanyService.Value;
    public IMockEmployeeService MockEmployeeService => _mockemployeeService.Value;
}