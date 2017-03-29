using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PimpYourCharacter.Startup))]
namespace PimpYourCharacter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
