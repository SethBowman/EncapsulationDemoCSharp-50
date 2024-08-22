namespace EncapsulationDemoCSharp_50;

public class Person
{
    //Properties
    public string Name { get; set; }
    public int Age { get; set; }
    
    //Fields
    private double _wallet;
    
    //Methods (public) can access the private fields
    public void AddMoney(double moneyToAdd)
    {
        _wallet += moneyToAdd;
    }

    public double CheckWallet()
    {
        return _wallet;
    }
}