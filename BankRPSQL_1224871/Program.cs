using BankRPSQL_1224871;
using BankRPSQL_1224871.Data;
using BankRPSQL_1224871.DataLayer;
using BankRPSQL_1224871.ServicesBusiness;
using BankRPSQL_1224871.ServicesBusiness.BankRPSQL_1218645.ServicesBusiness;
using BankRPSQL_1224871.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("MYBANK") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddSingleton<IBusinessBanking, BusinessBanking>();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
ConnectionStringHelper.CONNSTR = connectionString;

//-----session setup--------------------
builder.Services.AddDistributedMemoryCache(); // for session storage
builder.Services.AddSession(opts =>
{
    opts.Cookie.Name = ".AYSite.SessionID"; // replace AM by your initials
    opts.IdleTimeout = TimeSpan.FromMinutes(5); // 5 minute session timeout
});
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSingleton<IBusinessAuthentication, BusinessAuthentication>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.UseSession(); // added by AY------------------
HttpContextHelper.Configure(app.Services.GetRequiredService<IHttpContextAccessor>());

app.Run();
