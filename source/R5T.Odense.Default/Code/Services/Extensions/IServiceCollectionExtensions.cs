using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Odense.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileProjectTypeGuidProvider"/> implementation of <see cref="IVisualStudioSolutionFileProjectTypeGuidProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultVisualStudioSolutionFileProjectTypeGuidProvider(this IServiceCollection services)
        {
            services.AddSingleton<IVisualStudioSolutionFileProjectTypeGuidProvider, VisualStudioSolutionFileProjectTypeGuidProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileProjectTypeGuidProvider"/> implementation of <see cref="IVisualStudioSolutionFileProjectTypeGuidProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IVisualStudioSolutionFileProjectTypeGuidProvider> AddDefaultVisualStudioSolutionFileProjectTypeGuidProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IVisualStudioSolutionFileProjectTypeGuidProvider>(() => services.AddDefaultVisualStudioSolutionFileProjectTypeGuidProvider());
            return serviceAction;
        }
    }
}
