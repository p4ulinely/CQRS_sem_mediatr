using CQRS_sem_mediatr.CommandsHandlers;
using CQRS_sem_mediatr.QueriesHandlers;
using CQRS_sem_mediatr.Services;
using Domain.Repositories;
using Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS_sem_mediatr
{
    public static class IoC
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IOrderRepository, OrderRepository>();

            services.AddScoped<IOrderService, OrderService>();
        }

        public static void AddHandlers(this IServiceCollection services)
        {
            services.AddScoped<AddOrderCommandHandler>();

            services.AddScoped<GetOrderQueryHandler>();
        }
    }
}
