namespace Task6.Test;

public class Tests
{


    [Test]
    public void TestPingPong()
    {
        Assert.IsTrue(Program.PingPong("PingPong").Equals("PongPing"));
    }

    [Test]
    public void TestPing()
    {
        Assert.IsTrue(Program.PingPong("Ping").Equals("Pong"));
    }

    [Test]
    public void TestPong()
    {
        Assert.IsTrue(Program.PingPong("Pong").Equals("Ping"));
    }

        [Test]
    public void TestCheck()
    {
        Assert.IsTrue(Program.PingPong("Banana").Equals("Check"));
        Assert.IsTrue(Program.PingPong("Apple").Equals("Check"));
        Assert.IsTrue(Program.PingPong("FASKGFJSKFA").Equals("Check"));
        Assert.IsTrue(Program.PingPong("111111").Equals("Check"));
        Assert.IsTrue(Program.PingPong("Lorem Ipsum").Equals("Check"));
    }
}