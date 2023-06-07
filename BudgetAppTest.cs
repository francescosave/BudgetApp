using Xunit;
public class BudgetAppTest
{

    [Fact]
    public void Create_category_test(){

        Category category = new Category("clothing");
        Category expetedCategory = new Category("clothing");
        Assert.Equal(expetedCategory,category);
    }
    
    [Fact]
    public void Compare_legdger_test(){
        Category category = new Category("food")
            {
                ledger = new List<LedgerItem>(){new LedgerItem("bread",30),new LedgerItem("water",10)}
            };
        Category expetedCategory = new Category("food")
            {
                ledger = new List<LedgerItem>(){new LedgerItem("bread",30),new LedgerItem("water",10)}
            };
       
        Assert.Equal(expetedCategory.ledger,category.ledger);
    }

    [Fact]
    public void AddDepositTest(){
        Category category = new Category("food")
            {
                ledger = new List<LedgerItem>(){new LedgerItem("bread",30),new LedgerItem("water",10)}
            };
        Category expetedCategory = new Category("food")
            {
                ledger = new List<LedgerItem>(){new LedgerItem("bread",30),new LedgerItem("water",10)}
            };

        Assert.Equal(expetedCategory.AddDeposit(new LedgerItem("caffe",1)) ,category.AddDeposit(new LedgerItem("caffes",10)));
    }

}

public record Category (string categorName)
{
    public List<LedgerItem> ledger;

    public Boolean AddDeposit(LedgerItem ledgerItem)
    {
        ledger.Add(ledgerItem);
        return true;
    }
}

public record LedgerItem(String Description,int price){}