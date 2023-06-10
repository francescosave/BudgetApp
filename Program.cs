
Category category = new Category("food");  

category.ledger = new List<LedgerItem>(){};
Console.WriteLine($"category.ledger contiene : {category.ledger.Count}");
category.AddDeposit(new LedgerItem("bread",10));
Console.WriteLine($"category.ledger contiene : {category.ledger[0].Description}");

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
