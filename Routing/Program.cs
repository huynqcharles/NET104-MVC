var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Privacy}/{id?}");

//app.UseEndpoints(endpoints =>
//{
//    endpoints.Map("/test/test/{id:int?}", async (context) =>
//    {
//        var id = context.Request.RouteValues["id"];
//        if (id == null)
//        {
//            await context.Response.WriteAsync("Dang o trang test khong co id");
//        }
//        else
//        {
//            await context.Response.WriteAsync($"Dang o trang test voi id la: {id}");
//        }
//    });
//});

app.Run();
