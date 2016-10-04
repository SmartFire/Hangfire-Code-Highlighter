using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Hangfire.Highlighter.Startup1))]

namespace Hangfire.Highlighter
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("HighlighterDb");

            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}
