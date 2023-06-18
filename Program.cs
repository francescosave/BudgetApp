
Category category = new Category("food");  

category.ledger = new List<LedgerItem>(){};

const string initial_description = "Initial deposit";
const int initial_deposit = 1000;
const string withedraw_description = "restaurant";
const int withedraw_amount = -700;

category.AddDeposit(new LedgerItem(initial_description,initial_deposit));
category.AddWithedraw(new LedgerItem(withedraw_description,withedraw_amount));
//category.AddWithedraw(new LedgerItem("restaurant",-155));
//category.AddWithedraw(new LedgerItem("restaurant",-745));
//category.AddDeposit(new LedgerItem("initial deposit",100));
//category.AddWithedraw(new LedgerItem("restaurant",-101));
Console.WriteLine($"{initial_description}: {initial_deposit}");
Console.WriteLine($"{withedraw_description}: {withedraw_amount}");
Console.WriteLine($"{category.categoryName} balance is : {category.getBalance()}");

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

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
