using Microsoft.EntityFrameworkCore;
using ChamadosTecnicos.Data;

var builder = WebApplication.CreateBuilder(args);

// ⚠️ Tudo abaixo deve vir ANTES do `builder.Build()`

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=chamados.db"));

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 🔽 Agora sim é a parte do app (pipeline HTTP)

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ticket}/{action=Index}/{id?}");

app.Run();

