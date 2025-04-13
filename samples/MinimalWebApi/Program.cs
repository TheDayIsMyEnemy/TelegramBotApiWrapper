using TelegramBotApiWrapper;
using TelegramBotApiWrapper.Requests;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ITelegramBotApiClientOptions, TelegramBotApiClientOptions>(
    serviceProvider => new TelegramBotApiClientOptions
    {
        ApiKey = builder.Configuration["TelegramBotApiClientOptions:ApiKey"]!
    });
builder.Services.AddHttpClient<ITelegramBotApiClient, TelegramBotApiClient>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/getMe", async (ITelegramBotApiClient client) => { var res = await client.GetMe(); return res; }).WithName("GetMe").WithOpenApi();
app.MapGet("/getUpdates", async (ITelegramBotApiClient client) => { var res = await client.GetUpdates(); return res; }).WithName("GetUpdates").WithOpenApi();
app.MapPost("/sendMessage", async (ITelegramBotApiClient client, SendMessageRequest req) => { var res = await client.SendMessage(req); return TypedResults.StatusCode((int)res); }).WithName("SendMessage").WithOpenApi();

app.Run();