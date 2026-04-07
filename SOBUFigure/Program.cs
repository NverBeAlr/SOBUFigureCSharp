using SOBUFigure.Components;
using SOBUFigure.Data;
using SOBUFigure.Services.Categories;
using Microsoft.EntityFrameworkCore;
using SOBUFigure.Services.Admins;
using SOBUFigure.Services.Brands;
using SOBUFigure.Services.Customers;
using SOBUFigure.Services.Figures;
using SOBUFigure.Services.OrderDetails;
using SOBUFigure.Services.Orders;

var builder = WebApplication.CreateBuilder(args);

//Add Connection
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseMySQL(
        builder.Configuration.GetConnectionString("DefaultString")
    )    
);

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IFigureService, FigureService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderDetailService, OrderDetailService>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();