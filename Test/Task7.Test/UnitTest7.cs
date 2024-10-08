namespace Task7.Test;

public class Tests
{

    [Test]
    public void Test7()
    {
        Assert.IsTrue(Program.Greeting("John").Equals("Hello John"));
        Assert.IsTrue(Program.Greeting("Banana").Equals("Hello Banana"));
        Assert.IsTrue(Program.Greeting("Peter").Equals("Hello Peter"));
        Assert.IsTrue(Program.Greeting("Jakob").Equals("Hello Jakob"));
        Assert.IsTrue(Program.Greeting("Helena").Equals("Hello Helena"));
        Assert.IsTrue(Program.Greeting("Sarah").Equals("Hello Sarah"));
        Assert.IsTrue(Program.Greeting("1111").Equals("Hello 1111"));
        Assert.IsTrue(Program.Greeting("User").Equals("Hello User"));
        Assert.IsTrue(Program.Greeting("Pizza").Equals("Hello Pizza"));
    }
}