using SmartTask.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
       .AddControllers()
       .Services
       .AddSwaggerGenerator()
       .ConfigureSqlContext(builder.Configuration)
       .AddServices()
       .AddAutoMapper(typeof(Program));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.MapControllers();
app.Run();
