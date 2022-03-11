using CliDemo.Domain.Common;
using System.Threading.Tasks;

namespace CliDemo.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
