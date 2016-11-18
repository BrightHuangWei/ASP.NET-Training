using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineHotelReservationSystem.Startup))]
namespace OnlineHotelReservationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
