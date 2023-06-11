
Category category = new Category("food");  

category.ledger = new List<LedgerItem>(){};
category.AddDeposit(new LedgerItem("initial deposit",1000));
category.AddWithedraw(new LedgerItem("restaurant",-100));
category.AddWithedraw(new LedgerItem("restaurant",-155));
category.AddWithedraw(new LedgerItem("restaurant",-745));
category.AddDeposit(new LedgerItem("initial deposit",100));
category.AddWithedraw(new LedgerItem("restaurant",-101));
Console.WriteLine($"{category.categoryName} balance is : {category.getBalance()}");

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
