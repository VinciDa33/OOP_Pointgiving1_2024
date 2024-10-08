namespace Task7.Test;

public class Tests
{

    [Test]
    public void Test7()
    {
        Assert.IsTrue(Program.Greeting("John").ToLower().Equals("hello john"));
        Assert.IsTrue(Program.Greeting("Banana").ToLower().Equals("hello john"));
        Assert.IsTrue(Program.Greeting("Peter").ToLower().Equals("hello john"));
        Assert.IsTrue(Program.Greeting("Jakob").ToLower().Equals("hello john"));
        Assert.IsTrue(Program.Greeting("Helena").ToLower().Equals("hello john"));
        Assert.IsTrue(Program.Greeting("Sarah").ToLower().Equals("hello john"));
        Assert.IsTrue(Program.Greeting("1111").ToLower().Equals("hello john"));
        Assert.IsTrue(Program.Greeting("User").ToLower().Equals("hello john"));
        Assert.IsTrue(Program.Greeting("Pizza").ToLower().Equals("hello john"));
    }
}