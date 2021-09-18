using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.DataAccess.EntityRepositories;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Services;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Api
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
            services.AddControllers();
            services.AddDbContext<WorkerBenefitsDbContext>
               (
                   x => x.UseSqlServer("Server=localhost;Database=WorkerBenefitsDb;Trusted_Connection=True")
               );

            services.AddTransient<IWorkerEntityRepository, WorkerEntityRepository>();
            services.AddTransient<IRepository<TechnologyTypeEnrolment>, TechnologyTypeEnrolmentEntityRepository>();
            services.AddTransient<IRepository<TechnologyType>, TechnologyTypeEntityRepository>();
            services.AddTransient<IRepository<JobPositionEnrolment>, JobPositionEnrolmentEntityRepository>();
            services.AddTransient<IRepository<JobPosition>, JobPositionEntityRepository>();
            services.AddTransient<IRepository<IndividualEnrolment>, IndividualEnrolmentEntityRepository>();
            services.AddTransient<IRepository<Benefit>, BenefitEntityRepository>();
            services.AddTransient<IBenefitService, BenefitService>();
            services.AddTransient<IWorkerService, WorkerService>();
            services.AddTransient<IIndividualEnrolmentService, IndividualEnrolmentService>();
            services.AddTransient<ITechnologyTypeService, TechnologyTypeService>();
            services.AddTransient<ITechnologyTypeEnrolmentService, TechnologyTypeEnrolmentService>();
            services.AddTransient<IJobPositionService, JobPositionService>();
            services.AddTransient<IJobPositionEnrolmentService, JobPositionEnrolmentService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
