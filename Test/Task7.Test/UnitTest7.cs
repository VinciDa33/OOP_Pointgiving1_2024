namespace Task7.Test;

public class Tests
{

    [Test]
    public void Test7()
    {
        Program p = new Program();

        Assert.IsTrue(p.Greeting("John").Equals("Hello John"));
        Assert.IsTrue(p.Greeting("Banana").Equals("Hello Banana"));
        Assert.IsTrue(p.Greeting("Peter").Equals("Hello Peter"));
        Assert.IsTrue(p.Greeting("Jakob").Equals("Hello Jakob"));
        Assert.IsTrue(p.Greeting("Helena").Equals("Hello Helena"));
        Assert.IsTrue(p.Greeting("Sarah").Equals("Hello Sarah"));
        Assert.IsTrue(p.Greeting("1111").Equals("Hello 1111"));
        Assert.IsTrue(p.Greeting("User").Equals("Hello User"));
        Assert.IsTrue(p.Greeting("Pizza").Equals("Hello Pizza"));
    }
}