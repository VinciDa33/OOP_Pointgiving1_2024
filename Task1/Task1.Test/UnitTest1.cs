namespace Task1.Test;

public class Tests
{
    [Test]
    public void Test1()
    {
        //WIP - Placeholder testing!
        string result = Program.SomeFunctionToImplement("Hello", 5);

        Assert.NotNull(result);
        Assert.IsTrue(result.Equals("Hello5"));
    }
}