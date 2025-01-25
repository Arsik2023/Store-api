using Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGenCustomConfig();
builder.Services.AddControllers();
builder.Services.AddPosgreSqlDbContext(builder.Configuration); // включение класса PosgreSqlServiceExtension
builder.Services.AddPostgreSqlIdentityContext(); // включение класса PostgreSqlIdentityContext
builder.Services.AddConfigureIdentityOptions(); // настройки пароля
builder.Services.AddJwtTokenGenerator();
builder.Services.AddAuthenticationConfig(builder.Configuration);
builder.Services.AddCors();
builder.Services.AddShoppingCartService();
builder.Services.AddOrdersService();
builder.Services.AddPaymentService();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.UseHttpsRedirection();

app.UseCors(o =>
    o.AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin()
    .WithExposedHeaders("*")
    );

app.UseAuthentication();
app.UseAuthorization();

await app.Services.InitializeRoleAsync();

app.Run();