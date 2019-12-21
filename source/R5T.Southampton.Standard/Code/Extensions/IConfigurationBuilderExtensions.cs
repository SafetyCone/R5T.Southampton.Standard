using System;

using Microsoft.Extensions.Configuration;

using R5T.Southampton.Larissa.Standard;


namespace R5T.Southampton.Standard
{
    public static class IConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddSourceControlOperatorConfiguration(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            configurationBuilder
                .AddSvnSourceControlOperatorConfiguration(configurationServiceProvider)
                ;

            return configurationBuilder;
        }
    }
}
