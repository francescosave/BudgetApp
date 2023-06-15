
Category category = new Category("food");  

category.ledger = new List<LedgerItem>(){};
category.AddDeposit(new LedgerItem("initial deposit",1000));
category.AddWithedraw(new LedgerItem("restaurant",-700));
//category.AddWithedraw(new LedgerItem("restaurant",-155));
//category.AddWithedraw(new LedgerItem("restaurant",-745));
//category.AddDeposit(new LedgerItem("initial deposit",100));
//category.AddWithedraw(new LedgerItem("restaurant",-101));
Console.WriteLine($"{category.categoryName} balance is : {category.getBalance()}");

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

PrintBudget(category);


void PrintBudget(Category category){

    // Print
    Console.WriteLine("-------------------------------");
    Console.WriteLine($"  *** {category.categoryName} ***");
    Console.WriteLine("-------------------------------");
    
    foreach (var itemLedger in category.ledger)
    {
      Console.WriteLine(String.Format("{0,-22} | {1,6}", itemLedger.Description, itemLedger.amount));  
    }
        
    Console.WriteLine($"TOTAL: {category.getBalance()}");
    Console.WriteLine("-------------------------------");

    // Console app: center text
    //Console.WriteLine(String.Format("{0," + 30 / 2 + "}", "TEXT"));

}
