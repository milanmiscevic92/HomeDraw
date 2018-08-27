using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using DAL.Infrastructure;
using WebUI.Infrastructure;
using Microsoft.AspNet.SignalR;
using WebUI.Hubs;
using DAL.Concrete;
using DAL.Abstract;

namespace WebUI.App_Start
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalHost.DependencyResolver.Register(
                typeof(ServerHub),
                () => new ServerHub(new UnitOfWork()));

            app.MapSignalR();

            app.CreatePerOwinContext<HomeDrawDbContext>(HomeDrawDbContext.Create);
            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
            app.CreatePerOwinContext<AppRoleManager>(AppRoleManager.Create);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Home/LogIn"),
            });
        }
    }
}