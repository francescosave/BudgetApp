using Xunit;
public class ClassTest
{

    [Fact]
    public void Create_category_test(){

        Category category = new Category("food");
        Category expetedCategory = new Category("food");
        Assert.Equal(expetedCategory,category);
    }
    
}