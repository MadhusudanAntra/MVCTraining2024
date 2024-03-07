using Antra.Training.ApplicationCore.RepositoryInterface;
using Antra.Training.Infrastructure.Data;
using Antra.Training.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TrainingDbContext>(option => {

    option.UseSqlServer(builder.Configuration.GetConnectionString("TrainingDB"));
});

builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>(); //IDepartmentRepository repo = new DepartmentRepository();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
