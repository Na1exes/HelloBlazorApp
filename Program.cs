using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using HelloBlazorApp.Data;
using HelloBlazorApp.Services;
using HelloBlazorApp.Components;

var builder = WebApplication.CreateBuilder(args);

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

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();


//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();
//builder.Services.AddServerSideBlazor();

//builder.Services.AddTransient<MaterialPostServices>();
//builder.Services.AddTransient<ProposalPostServices>();

//var DBContextConnectionString = builder.Configuration.GetConnectionString(nameof(PurchaseContext));
//builder.Services.AddDbContextFactory<PurchaseContext>(options => options.UseNpgsql(DBContextConnectionString));

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();

//app.UseStaticFiles();

//app.UseRouting();

//app.MapBlazorHub();
//app.MapFallbackToPage("/_Host");

//app.Run();
