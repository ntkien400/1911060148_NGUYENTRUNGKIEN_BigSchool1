using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911060148_NGUYENTRUNGKIEN_BigSchool1.Startup))]
namespace _1911060148_NGUYENTRUNGKIEN_BigSchool1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
