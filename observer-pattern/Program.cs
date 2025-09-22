using observer_pattern;
using observer_pattern.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

var sysBitcoin = new Bitcoin(156000);

var binanceApi = new BinanceAPI();
var bitcoinLastPrice = binanceApi.GetLastPrice();

sysBitcoin.AddObserver(new BitcoinPriceLogger()); 
sysBitcoin.AddObserver(new InvestorNotify());
sysBitcoin.AddObserver(new NewsPlatform());

sysBitcoin.SetPrice(bitcoinLastPrice); // tornar o código reativo

app.Run();