using Xunit;
public class BudgetAppTest
{

    [Fact]
    public void Create_category_test(){

        Category category = new Category("clothing");
        Category expetedCategory = new Category("clothing");
        Assert.Equal(expetedCategory,category);
    }
    
}

public record Category (string categorName)
{

}