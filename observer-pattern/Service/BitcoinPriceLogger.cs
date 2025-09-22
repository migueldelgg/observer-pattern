using observer_pattern.Service.Interface;

namespace observer_pattern.Service;

public class BitcoinPriceLogger : BitcoinPriceObserver
{
    public void Update(double price)
    {
        // loga sempre
    }
}