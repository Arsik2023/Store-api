using Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddPosgreSqlDbContext(builder.Configuration); // включение класса PosgreSqlServiceExtension
builder.Services.AddPostgreSqlIdentityContext(); // включение класса PostgreSqlIdentityContext
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();
app.Run();

