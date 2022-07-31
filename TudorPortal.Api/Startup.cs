////using FluentValidation.AspNetCore;
////using Microsoft.AspNetCore.Builder;
////using Microsoft.AspNetCore.Hosting;
////using Microsoft.AspNetCore.HttpsPolicy;
////using Microsoft.AspNetCore.Mvc;
////using Microsoft.Extensions.Configuration;
////using Microsoft.Extensions.DependencyInjection;
////using Microsoft.Extensions.Hosting;
////using Microsoft.Extensions.Logging;
//using Microsoft.OpenApi.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TudorPortal.Api.Filters;
//using TudorPortal.Business;
//using TudorPortal.Business.Services;
//using TudorPortal.Business.Services.IServices;
//using TudorPortal.Persistance;

//namespace TudorPortal.Api
//{
//    public class Startup
//    {
//        //        public Startup(IConfiguration configuration)
//        //        {
//        //            Configuration = configuration;
//        //        }

//        //        public IConfiguration Configuration { get; }

//        //        // This method gets called by the runtime. Use this method to add services to the container.
//        //        public void ConfigureServices(IServiceCollection services)
//        //        {

//        //            services.AddControllers();
//        //            services.AddPersistanceServices(Configuration);
//        //            services.AddBusinessServices();

//        //            services.AddSwaggerGen(c =>
//        //            {
//        //                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TudorPortal.Api", Version = "v1" });
//        //            });
//        //        }

//        //        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        //        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        //        {
//        //            if (env.IsDevelopment())
//        //            {
//        //                app.UseDeveloperExceptionPage();
//        //                app.UseSwagger();
//        //                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TudorPortal.Api v1"));
//        //            }

//        //            app.UseHttpsRedirection();

//        //            app.UseRouting();

//        //            app.UseAuthorization();

//        //            app.UseEndpoints(endpoints =>
//        //            {
//        //                endpoints.MapControllers();
//        //            });
//        //        }
//        //        private void BuildMvc(IServiceCollection services)
//        //        {
//        //            services.AddMvc(options => { options.Filters.Add(typeof(ValidationFilter)); })
//        //                .AddFluentValidation(c => { c.RegisterValidatorsFromAssemblyContaining<Startup>(); })
//        //                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
//        //        }
//    }
//}
