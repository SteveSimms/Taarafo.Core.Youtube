var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint(
        url: "/swagger/v1/swagger.json",
        name: "Taarafo.Core v1");
    });


}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();

