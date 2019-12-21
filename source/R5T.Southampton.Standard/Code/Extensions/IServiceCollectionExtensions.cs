using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Southampton.Larissa.Standard;


namespace R5T.Southampton.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddSourceControlOperator(this IServiceCollection services)
        {
            services
                .AddSvnSourceControlOperator()
                ;

            return services;
        }
    }
}
