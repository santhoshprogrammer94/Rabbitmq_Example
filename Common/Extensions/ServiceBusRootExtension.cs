using Common.RabbitMq;
using Microsoft.Extensions.DependencyInjection;

namespace Common.Extensions
{
    public static class ServiceBusRootExtension
    {
        public static void AddServiceBus(this IServiceCollection service, string endPointId, string endPointName)
        {
            var rabbitMqBusInstance = new RabbitMqBus(endPointId,endPointName);
            
            service.AddSingleton(typeof(IRabbitMqBus),rabbitMqBusInstance);
            service.AddSingleton(typeof(RabbitMqBus), rabbitMqBusInstance);
        }
    }
}