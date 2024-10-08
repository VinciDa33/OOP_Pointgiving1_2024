namespace Task7.Test;

public class Tests
{

    [Test]
    public void Test7()
    {
        Assert.IsTrue(Program.Greeting("John").Equals("Hello John"));
    }
}