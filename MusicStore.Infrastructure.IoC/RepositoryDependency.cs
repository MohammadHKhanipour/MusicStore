using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MusicStore.Domain.Models;
using MusicStore.Infrastructure.Context;
using MusicStore.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Infrastructure.IoC
{
    public class RepositoryDependency
    {
        public static void RegisterDatabase(IServiceCollection services, string connectionString)
        {
            #region Register Database
            services.AddDbContext<MusicStoreDbContext>(options => options.UseSqlServer(connectionString));
            #endregion
        }

        public static void RegisterRepositories(IServiceCollection services)
        {
            #region Register Repositories
            services.AddScoped<ICommandRepository<ApplicationUser>, CommandRepository<ApplicationUser>>();
            services.AddScoped<ICommandRepository<Bill>, CommandRepository<Bill>>();
            services.AddScoped<ICommandRepository<Category>, CommandRepository<Category>>();
            services.AddScoped<ICommandRepository<Order>, CommandRepository<Order>>();
            services.AddScoped<ICommandRepository<OrderDetail>, CommandRepository<OrderDetail>>();
            services.AddScoped<ICommandRepository<Product>, CommandRepository<Product>>();
            services.AddScoped<ICommandRepository<ProductImage>, CommandRepository<ProductImage>>();
            services.AddScoped<ICommandRepository<ProductLink>, CommandRepository<ProductLink>>();
            services.AddScoped<ICommandRepository<UserNotification>, CommandRepository<UserNotification>>();
            services.AddScoped<ICommandRepository<Wallet>, CommandRepository<Wallet>>();

            services.AddScoped<IQueryRepository<ApplicationUser>, QueryRepository<ApplicationUser>>();
            services.AddScoped<IQueryRepository<Bill>, QueryRepository<Bill>>();
            services.AddScoped<IQueryRepository<Category>, QueryRepository<Category>>();
            services.AddScoped<IQueryRepository<Order>, QueryRepository<Order>>();
            services.AddScoped<IQueryRepository<OrderDetail>, QueryRepository<OrderDetail>>();
            services.AddScoped<IQueryRepository<Product>, QueryRepository<Product>>();
            services.AddScoped<IQueryRepository<ProductImage>, QueryRepository<ProductImage>>();
            services.AddScoped<IQueryRepository<ProductLink>, QueryRepository<ProductLink>>();
            services.AddScoped<IQueryRepository<UserNotification>, QueryRepository<UserNotification>>();
            services.AddScoped<IQueryRepository<Wallet>, QueryRepository<Wallet>>();
            #endregion
        }
    }
}
