using System.Reflection;

namespace SnakeCaseJson.Api.ServiceCollection;

 public static class EndpointRegistration
    {
        public static void AddEndpoints(this IServiceCollection services, Assembly assembly)
        {
            var endpointTypes = assembly.GetTypes()
                .Where(t => typeof(IEndpoint).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

            foreach (var endpointType in endpointTypes)
            {
                services.AddSingleton(typeof(IEndpoint), endpointType);
            }
        }

        public static void MapEndpoints(this IEndpointRouteBuilder app)
        {
            var endpoints = app.ServiceProvider.GetServices<IEndpoint>();

            foreach (var endpoint in endpoints)
            {
                endpoint.MapEndpoints(app);
            }
        }
    }