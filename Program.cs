using TodoApi;
using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;

// טען את משתני הסביבה מקובץ .env
Env.Load();

// יצירת תשתית להגדרת כל השירותים והתצורות ליצירת האפליקציה
var builder = WebApplication.CreateBuilder(args);

// הוספת שירותי DbContext עם מחרוזת החיבור
var connectionString = Environment.GetEnvironmentVariable("ToDoDB");
builder.Services.AddDbContext<ToDoDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddSingleton<Item>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(x => x.AddPolicy("all", a => a.AllowAnyHeader()
    .AllowAnyMethod().AllowAnyOrigin()));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("all");
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapGet("/", async (ToDoDbContext db) =>
{
    return "It's work";
});

app.MapPost("/register/{Name}/{Password}", async (string Name, string Password, ToDoDbContext db) =>
{
    if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Password))
    {
        return Results.BadRequest("Name and password are required.");
    }

    User u = new User() { Name = Name, Password = Password };
    db.Users.Add(u);
    await db.SaveChangesAsync();
    return Results.Ok(u.Id);
});

app.MapPost("/login/{password}", async (string password, ToDoDbContext db) =>
{
    if (string.IsNullOrEmpty(password))
    {
        return Results.BadRequest("Name and password are required.");
    }

    var user = await db.Users.FirstOrDefaultAsync(x => x.Password == password);
    if (user == null)
    {
        return Results.Unauthorized();
    }

    return Results.Ok(user.Id);
});

app.MapGet("/allTasks", async (ToDoDbContext db, int userId) =>
{
    return await db.Items.Where(x => x.UserId == userId).ToListAsync();
});

app.MapPost("/addTask/{NameT}/{userId}", async (string NameT, int userId, ToDoDbContext db) =>
{
    var user = await db.Users.FindAsync(userId);
    if (user == null)
    {
        return Results.NotFound("User not found");
    }

    Item t = new Item() { NameT = NameT, IsComplete = 0, UserId = userId };
    db.Items.Add(t);
    await db.SaveChangesAsync();
    return Results.Ok(t);
});

app.MapDelete("/deleteTask/{id}", async (int id, ToDoDbContext db) =>
{
    var item = await db.Items.FindAsync(id);
    if (item != null)
    {
        db.Items.Remove(item);
        await db.SaveChangesAsync();
    }
});

app.MapPut("/updateTask/{id}", async (int id, ToDoDbContext db) =>
{
    var item = await db.Items.FindAsync(id);
    if (item.IsComplete == 0)
    {
        item.IsComplete = 1;
    }
    else
    {
        item.IsComplete = 0;
    }
    db.Items.Update(item);
    await db.SaveChangesAsync();
    return item;
});

app.Run();