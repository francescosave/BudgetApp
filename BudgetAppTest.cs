using Xunit;
public class BudgetAppTest
{

    [Fact]
    public void Create_category_test(){

        // Assign & Act
        Category category = new Category("clothing");
        Category expetedCategory = new Category("clothing");
        
        //Assert
        Assert.Equal(expetedCategory,category);
    }
    
[Fact]
    public void Compare_legdger_test(){

        //Assign
        Category category = new Category("food");
        Category expetedCategory = new Category("food");

        //Act
        category.ledger = new List<LedgerItem>(){};
        category.AddDeposit(new LedgerItem("initial deposit",1000));
        expetedCategory.ledger = new List<LedgerItem>(){};
        expetedCategory.AddDeposit(new LedgerItem("initial deposit",1000));

        //Assert
        Assert.Equal(expetedCategory.ledger,category.ledger);
    
    }

    [Fact]
    public void AddDepositTestBool(){

        //Assign
        Category category = new Category("food");
        Category expetedCategory = new Category("food");

        //Act
        category.ledger = new List<LedgerItem>(){};
        expetedCategory.ledger = new List<LedgerItem>(){};
        bool isDepositSuccess = expetedCategory.AddDeposit(new LedgerItem("initial deposit",1000));

        //Assert
        Assert.Equal( true ,isDepositSuccess);
    
    }

    [Fact]
    public void AddWithedrawTestBool(){

        //Assign
        Category category = new Category("food");
        Category expetedCategory = new Category("food");

        //Act
        //the Withedraw is possible only where amount is pari o inferiore al saldo
        category.ledger = new List<LedgerItem>(){};
        expetedCategory.ledger = new List<LedgerItem>(){};
        expetedCategory.AddDeposit(new LedgerItem("initial deposit",1000));
        bool isWithedrawSuccess = expetedCategory.AddWithedraw(new LedgerItem("restaurant",-1001));

        //Assert
        Assert.Equal( true ,isWithedrawSuccess);
    
    }

    [Fact]
    public void getBalanceTest(){

        //Assign
        Category category = new Category("food");
        Category expetedCategory = new Category("food");

        //Act
        //the Withedraw is possible only where amount is pari o inferiore al saldo
        category.ledger = new List<LedgerItem>(){};
        category.AddDeposit(new LedgerItem("initial deposit",1000));
        bool isWithedrawSuccess = category.AddWithedraw(new LedgerItem("restaurant",-1001));
        int balance = category.getBalance();

        //Assert
        // initial deposit 1000 - restaurant 100 =>> balance 900
        Assert.Equal(1000,balance);
    
    }


}

public record Category (string categoryName)
{
    
    // Se la istanzio qui la lista anche vuota mi va in errore il test
    //public List<LedgerItem> ledger = new List<LedgerItem>();
    public List<LedgerItem> ledger;

    public bool AddDeposit(LedgerItem ledgerItem)
    {
        ledger.Add(ledgerItem);
        //Console.WriteLine($"AddDeposit:   {ledgerItem.Description} =>> {ledgerItem.amount}");
        return true;
    }

    public bool AddWithedraw(LedgerItem ledgerItem)
    {
        
        // modify manage Withedraw negative amount inside method
        //ledgerItem.amount = System.Math.Abs(ledgerItem.amount);
        
        bool result = false;
        
        //Console.WriteLine($"AddWithedraw: {ledgerItem.Description} =>> {ledgerItem.amount} (balance={getBalance()})");
        if(System.Math.Abs(ledgerItem.amount) <=  getBalance()){
            ledger.Add(ledgerItem);
            Console.WriteLine($"AddWithedraw: {ledgerItem.Description} =>> {ledgerItem.amount}");
            result = true;
        } else {
            Console.WriteLine($"Don't possible Withedraw! ");
            result = false;
        }
        return result;

        
    }

    public int getBalance()
    {
        int balance = 0;
        foreach (var item in ledger)
        {
            balance += item.amount;
        }
        return balance;
    }
}

public record LedgerItem(String Description,int amount){}