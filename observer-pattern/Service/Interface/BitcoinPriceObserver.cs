namespace observer_pattern.Service.Interface;

public interface BitcoinPriceObserver
{
    public void Update(double price);
}