using BlogApp.Data;
using BlogApp.Services;
using DotNetEnv;

Env.Load();

var builder = WebApplication.CreateBuilder(args);

// Register DbContext
builder.Services.AddDbContext<BlogAppDbContext>();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<UserService>();

// CORS setup
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        string allowedOrigin = builder.Configuration["ALLOWED_ORIGIN"]!;
        policy.WithOrigins(allowedOrigin).AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();

app.MapControllers();

app.Run();
