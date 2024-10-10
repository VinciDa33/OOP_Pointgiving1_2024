namespace Task6.Test;

public class Tests
{

    [Test]
    public void TestPingPong()
    {
        Program p = new Program();

        Assert.IsTrue(p.PingPong("PingPong").Equals("PongPing"));
    }

    [Test]
    public void TestPing()
    {
        Program p = new Program();

        Assert.IsTrue(p.PingPong("Ping").Equals("Pong"));
    }

    [Test]
    public void TestPong()
    {
        Program p = new Program();

        Assert.IsTrue(p.PingPong("Pong").Equals("Ping"));
    }

        [Test]
    public void TestCheck()
    {
        Program p = new Program();

        Assert.IsTrue(p.PingPong("Banana").Equals("Check"));
        Assert.IsTrue(p.PingPong("Apple").Equals("Check"));
        Assert.IsTrue(p.PingPong("FASKGFJSKFA").Equals("Check"));
        Assert.IsTrue(p.PingPong("111111").Equals("Check"));
        Assert.IsTrue(p.PingPong("Lorem Ipsum").Equals("Check"));
    }
}