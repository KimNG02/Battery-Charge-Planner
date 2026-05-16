using Battery_Charge_Planner.backend;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

app.UseCors("AllowFrontend");

app.MapGet("/", () => "Battery Charge Planner API is running");

app.MapPost("/api/battery/recommendation", (BatteryRequest request) =>
{
    string recommendation;
    string reason;

    if (request.BatteryLevel < 0 || request.BatteryLevel > 100)
    {
        return Results.BadRequest("Battery level must be between 0 and 100.");
    }

    if (request.ElectricityPrice < 0)
    {
        return Results.BadRequest("Electricity price cannot be negative.");
    }

    if (request.ElectricityPrice < 1.0 && request.BatteryLevel < 90)
    {
        recommendation = "Charge battery";
        reason = "Electricity price is low and the battery is not full.";
    }
    else if (request.ElectricityPrice > 2.0 && request.BatteryLevel > 20)
    {
        recommendation = "Use battery power";
        reason = "Electricity price is high and the battery has enough charge.";
    }
    else if (request.BatteryLevel <= 20)
    {
        recommendation = "Save battery";
        reason = "Battery level is low, so it should not be discharged.";
    }
    else if (request.BatteryLevel >= 90)
    {
        recommendation = "Do not charge";
        reason = "Battery is already almost full.";
    }
    else
    {
        recommendation = "Do nothing";
        reason = "Electricity price and battery level are in a normal range.";
    }

    return Results.Ok(new
    {
        batteryLevel = request.BatteryLevel,
        electricityPrice = request.ElectricityPrice,
        recommendation,
        reason
    });
});

app.Run();