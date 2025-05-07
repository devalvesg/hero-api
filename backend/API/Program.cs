using Application.Mappings;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddData(builder.Configuration);
builder.Services.AddControllers(options =>
{
    options.Filters.Add<API.Filters.ApiResponseWrapperFilter>();
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularDev",
        policy => policy
            .WithOrigins("http://localhost:4200") 
            .AllowAnyHeader()
            .AllowAnyMethod()
    );
});
builder.Services.AddAutoMapper(typeof(MappingProfile));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("AllowAngularDev");

app.UseMiddleware<API.Middleware.ExceptionHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
