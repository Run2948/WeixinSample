﻿using Microsoft.Owin;
using Owin;
using WeixinSample;

[assembly: OwinStartup(typeof(Startup))]

namespace WeixinSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
