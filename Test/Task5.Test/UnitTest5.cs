namespace Task5.Test;

public class Tests
{
    [Test]
    public void TestReturnsTrue()
    {
        Assert.IsTrue(Program.CheckEvenOrThrow(10));
        Assert.IsTrue(Program.CheckEvenOrThrow(1208));
        Assert.IsTrue(Program.CheckEvenOrThrow(36));
        Assert.IsTrue(Program.CheckEvenOrThrow(-112));
        Assert.IsTrue(Program.CheckEvenOrThrow(8888888));
        Assert.IsTrue(Program.CheckEvenOrThrow(942));
        Assert.IsTrue(Program.CheckEvenOrThrow(14589284));
        Assert.IsTrue(Program.CheckEvenOrThrow(2));
        Assert.IsTrue(Program.CheckEvenOrThrow(1062));
    }

    [Test]
    public void TestThrowsException()
    {
        Assert.That(() => Program.CheckEvenOrThrow(3), Throws.Exception);
        Assert.That(() => Program.CheckEvenOrThrow(117), Throws.Exception);
        Assert.That(() => Program.CheckEvenOrThrow(93), Throws.Exception);
        Assert.That(() => Program.CheckEvenOrThrow(10687), Throws.Exception);
        Assert.That(() => Program.CheckEvenOrThrow(1), Throws.Exception);
        Assert.That(() => Program.CheckEvenOrThrow(-9), Throws.Exception);
        Assert.That(() => Program.CheckEvenOrThrow(57), Throws.Exception);
        Assert.That(() => Program.CheckEvenOrThrow(999999999), Throws.Exception);
    }
}