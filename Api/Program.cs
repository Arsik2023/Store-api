using Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddPosgreSqlDbContext(builder.Configuration); // включение класса PosgreSqlServiceExtension
builder.Services.AddPostgreSqlIdentityContext(); // включение класса PostgreSqlIdentityContext
builder.Services.AddConfigureIdentityOptions(); // настройки пароля
builder.Services.AddJwtTokenGenerator();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();

await app.Services.InitializeRoleAsync();

app.Run();