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
        Category category = new Category("food");
        Category expetedCategory = new Category("food");
        category.ledger =        new List<LedgerItem>(){new LedgerItem("bread",20),new LedgerItem("water",10)};
        expetedCategory.ledger = new List<LedgerItem>(){new LedgerItem("bread",20),new LedgerItem("water",10)};
        
        Assert.Equal(expetedCategory.ledger,category.ledger);
    }



}

public record Category (string categorName)
{
    public List<LedgerItem> ledger;
}

public record LedgerItem(String Description,int price){}