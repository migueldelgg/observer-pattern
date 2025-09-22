namespace observer_pattern;

public class BinanceAPI
{
    private readonly Random Rand = new Random();

    public double GetLastPrice() 
    {
        var price = Rand.NextDouble() * 999999;
        return Math.Round(price, 2);
    }
}