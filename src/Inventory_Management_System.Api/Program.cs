

using Microsoft.OpenApi;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try {

    Log.Information("Starting App");

    var builder = WebApplication.CreateBuilder(args);

    // -------------------------------------------------------
    // Step 2: Tell ASP.NET Core to use Serilog for all logging.
    // This replaces the default Microsoft logger completely.
    // -------------------------------------------------------

    builder.Host.UseSerilog((context, services, config) => config
      .ReadFrom.Configuration(context.Configuration)
      .ReadFrom.Services(services)
      .Enrich.FromLogContext());

    // Add services to the container.

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();

    // -------------------------------------------------------
    // Step 2: Integrating Swagger.
    // -------------------------------------------------------

    builder.Services.AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Inventory Management App API",
            Version = "v1",
            Description = "Backend API For Inventory Management App API"
        });
    });

    // -------------------------------------------------------
    // Step 3: Integrating CORS For Angular App.
    // -------------------------------------------------------

    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowAngular", policy =>
        {
            policy.WithOrigins("http://localhost:4200") // Angular default port
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
    });



    var app = builder.Build();

    // -------------------------------------------------------
    // Step 4: Configuring the Middleware Pipeline
    // Order matters here — each middleware runs top to bottom
    // on every incoming request.
    // -------------------------------------------------------


    // Show Swagger UI only in Development — never expose it in Production
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Inventory Management App Api v1");
            options.RoutePrefix = string.Empty; // opens Swagger at root URL "/"
        });
    }

    app.UseSerilogRequestLogging(options =>
    {
        options.MessageTemplate =
            "HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000}ms";
    });

    // In app middleware section — before UseHttpsRedirection
    app.UseCors("AllowAngular");

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    Log.Information("App Started Successfully");

    app.Run();


}
catch (Exception ex)
{

    // Captures fatal startup errors (e.g. DB connection failure,
    // missing config) in the log before the app crashes
    Log.Fatal(ex, "App failed to start.");
}

finally
{
    // Always flush and close log files cleanly on shutdown
    // so no log entries are lost when the app stops
    Log.CloseAndFlush();
}
