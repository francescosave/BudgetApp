
Category category = new Category("food");  

category.ledger = new List<LedgerItem>(){};
Console.WriteLine($"category.ledger contiene : {category.ledger.Count}");
category.AddDeposit(new LedgerItem("initial deposit",1000));
Console.WriteLine($"category.ledger contiene : {category.ledger[0].Description} {category.ledger[0].price}");

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
