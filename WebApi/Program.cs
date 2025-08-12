using WebApi;

var builder = WebApplication.CreateBuilder(args);

//add multiple exception handlers here
//they run in order of register
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

var app = builder.Build();

app.UseExceptionHandler();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    throw new NotImplementedException("Method not implemented yet");
});

app.Run();