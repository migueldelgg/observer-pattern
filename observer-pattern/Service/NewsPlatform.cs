using observer_pattern.Service.Interface;

namespace observer_pattern.Service;

public class NewsPlatform : BitcoinPriceObserver
{
    public void Update(double price)
    {
        // caso variacao maior que 20%
    }
    
}