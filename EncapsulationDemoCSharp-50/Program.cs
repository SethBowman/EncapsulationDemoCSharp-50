using EncapsulationDemoCSharp_50;

var seth = new Person();

var currentWallet = seth.CheckWallet();

Console.WriteLine(currentWallet);

seth.AddMoney(500.50);

currentWallet = seth.CheckWallet();

Console.WriteLine(currentWallet);