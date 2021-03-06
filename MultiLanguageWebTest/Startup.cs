﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MultiLaguageLibrary;
using MultiLanguageWebTest.JsonHelper;
using MultiLanguageWebTest.Model;

namespace MultiLanguageWebTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(Configuration);
            services.Configure<MultiLanguageChoose>(Configuration.GetSection("MultiLanguageChoose"));
            services.AddTransient<GetResourcesValue>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IOptions<MultiLanguageChoose> options)
        {
            //MultiLaguagePower.languageBind(JsonConfigurationHelper.GetAppSettings<MultiLanguageChoose>("MultiLanguageChoose").DirPath, JsonConfigurationHelper.GetAppSettings<MultiLanguageChoose>("MultiLanguageChoose").Language);
            MultiLaguagePower.languageBind(JsonConfigurationHelper.GetAppSettings(Configuration, options).DirPath, JsonConfigurationHelper.GetAppSettings(Configuration, options).Language);
            MultiLanguageConfigurationProvider.ServiceProvider = app.ApplicationServices;
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
