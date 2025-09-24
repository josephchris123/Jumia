using Jumia.Business;

namespace Jumia.Services
{
    public class DependencyInjection
    {
        public static void Registration(IServiceCollection services)
        {
            services.AddAutoMapper(p => { }, typeof(MappingBusiness).Assembly).AddScoped<AuthBusiness>();

        }
    }
}
