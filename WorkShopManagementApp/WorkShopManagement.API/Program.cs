using WorkShopManagement.BL.Profiles.ParticipantsProfiles;
using WorkShopManagement.BL.Services.Abstractions;
using WorkShopManagement.BL.Services.Implementations;
using WorkShopManagement.DAL.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(ParticipantProfile));

builder.Services.AddControllers();

builder.Services.AddServices();
builder.Services.AddScoped<IParticipantService, ParticipantService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
