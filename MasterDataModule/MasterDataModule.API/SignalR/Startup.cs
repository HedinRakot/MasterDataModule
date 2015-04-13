using Owin;

namespace MasterDataModule.API.SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
