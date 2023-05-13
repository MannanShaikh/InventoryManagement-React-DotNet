using Mobile_Store.Models;
using Mobile_Store.Interfaces;
using Mobile_Store.DBFactory;
using Mobile_Store.DBContext;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();

        #region Dependency Injection Container
        //Dependency Injection Container
        builder.Services.AddTransient<IAuthentication, Authentication>();
        builder.Services.AddTransient<ICustomer, Customer>();
        builder.Services.AddTransient<IUser, User>();
        builder.Services.AddTransient<ISupplier, Supplier>();
        builder.Services.AddTransient<IDBOperationLibrary, DBOperationLibrary>();
        builder.Services.AddSingleton<ISingletonDBFactory, SingletonDBFactory>();
        #endregion

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();


        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action=Index}/{id?}");

        app.MapFallbackToFile("index.html"); ;

        app.Run();
    }

}