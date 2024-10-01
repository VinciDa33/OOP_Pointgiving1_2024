namespace Task5.Test;

public class Tests
{
    [Test]
    public void TestThrowsException()
    {
        Assert.That(() => Program.CheckEvenOrThrow(3), Throws.Exception);
        Assert.That(() => Program.CheckEvenOrThrow(117), Throws.Exception);
    }

    [Test]
    public void TestReturnsTrue()
    {
        Assert.IsTrue(Program.CheckEvenOrThrow(10));
        Assert.IsTrue(Program.CheckEvenOrThrow(1208));
        Assert.IsTrue(Program.CheckEvenOrThrow(36));
    }
}