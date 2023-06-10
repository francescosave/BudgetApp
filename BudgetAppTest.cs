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
        category.AddDeposit(new LedgerItem("bread",10));
        expetedCategory.ledger = new List<LedgerItem>(){};
        expetedCategory.AddDeposit(new LedgerItem("bread",10));

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
        bool isDepositSuccess = expetedCategory.AddDeposit(new LedgerItem("caffe",10));

        //Assert
        Assert.Equal( true ,isDepositSuccess);
    
    }
}

public record Category (string categorName)
{
    
    // Se la istanzio qui la lista anche vuota mi va in errore il test
    public List<LedgerItem> ledger;

    public bool AddDeposit(LedgerItem ledgerItem)
    {
        ledger.Add(ledgerItem);
        return true;
    }
}

public record LedgerItem(String Description,int price){}