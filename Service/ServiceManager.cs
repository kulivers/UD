using Contracts;
using LoggerService;
using ServiceContracts;

namespace Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IMockCompanyService> _mockcompanyService;
    private readonly Lazy<IMockEmployeeService> _mockemployeeService;
    private readonly Lazy<ICompanyService> _companyService;
    private readonly Lazy<IItemService> _itemService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager
        logger)
    {
        _mockcompanyService = new Lazy<IMockCompanyService>(() => new
            MockCompanyService(repositoryManager, logger));
        _mockemployeeService = new Lazy<IMockEmployeeService>(() => new
            MockEmployeeService(repositoryManager, logger));
        _companyService = new Lazy<ICompanyService>(() => new CompanyService(repositoryManager, logger));
        _itemService = new Lazy<IItemService>(() => new ItemService(repositoryManager, logger));
    }

    public IMockCompanyService MockCompanyService => _mockcompanyService.Value;
    public IMockEmployeeService MockEmployeeService => _mockemployeeService.Value;
    public ICompanyService CompanyService => _companyService.Value;
    public IItemService ItemService => _itemService.Value;
}