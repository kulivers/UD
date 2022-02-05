using Contracts;
using LoggerService;
using ServiceContracts;

namespace Service;

public class ItemService : IItemService
{
    private readonly ILoggerManager _loggerManager;
    private readonly IRepositoryManager _repositoryManager;

    public ItemService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
    {
        _loggerManager = loggerManager;
        _repositoryManager = repositoryManager;
    }
}