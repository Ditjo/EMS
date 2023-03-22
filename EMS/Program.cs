using EMS.Data;
using EMS.Data.MockData;
using EMS.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<WeatherForecastService>();

if (false)
{
    //DataBase Data Scops
    //builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
    //builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
    //builder.Services.AddScoped<IJobTitleRepository, JobTitleRepository>();
}
else
{
    //MockData Scops
    builder.Services.AddScoped<IEmployeeRepository, EmployeeRepositoryMockData>();
    builder.Services.AddScoped<IDepartmentRepository, DepartmentRepositoryMockData>();
    builder.Services.AddScoped<IJobTitleRepository, JobTitleRepositoryMockData>();
}

//Services Scops
builder.Services.AddScoped<IEmployeeServices, EmployeeServices>();
builder.Services.AddScoped<IDepartmentServices, DepartmentServices>();
builder.Services.AddScoped<IJobTitleServices, JobTitleServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
