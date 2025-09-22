using observer_pattern.Service.Interface;

namespace observer_pattern;

public class Bitcoin
{
    private double Price {get; set;}
    private List<BitcoinPriceObserver> Observers { get; set; }

    public Bitcoin(double price)
    {
        this.Price = price;
    }

    public void SetPrice(double newPrice)
    {
        if (newPrice != this.Price) 
            this.Price = newPrice;
        
        this.NotifyObservers();
    }

    public void AddObserver(BitcoinPriceObserver observer)
    {
        this.Observers.Add(observer);
    }

    private void NotifyObservers()
    {
        foreach (BitcoinPriceObserver observer in this.Observers)
        {
            observer.Update(this.Price);
        } // cada observador vai reagir ao update da sua forma.
    }
}