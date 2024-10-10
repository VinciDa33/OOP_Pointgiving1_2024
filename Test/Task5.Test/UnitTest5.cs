namespace Task5.Test;

public class Tests
{
    [Test]
    public void TestReturnsTrue()
    {
        Program p = new Program();

        Assert.IsTrue(p.CheckEvenOrThrow(10));
        Assert.IsTrue(p.CheckEvenOrThrow(1208));
        Assert.IsTrue(p.CheckEvenOrThrow(36));
        Assert.IsTrue(p.CheckEvenOrThrow(-112));
        Assert.IsTrue(p.CheckEvenOrThrow(8888888));
        Assert.IsTrue(p.CheckEvenOrThrow(942));
        Assert.IsTrue(p.CheckEvenOrThrow(14589284));
        Assert.IsTrue(p.CheckEvenOrThrow(2));
        Assert.IsTrue(p.CheckEvenOrThrow(1062));
    }

    [Test]
    public void TestThrowsException()
    {
        Program p = new Program();

        Assert.That(() => p.CheckEvenOrThrow(3), Throws.Exception);
        Assert.That(() => p.CheckEvenOrThrow(117), Throws.Exception);
        Assert.That(() => p.CheckEvenOrThrow(93), Throws.Exception);
        Assert.That(() => p.CheckEvenOrThrow(10687), Throws.Exception);
        Assert.That(() => p.CheckEvenOrThrow(1), Throws.Exception);
        Assert.That(() => p.CheckEvenOrThrow(-9), Throws.Exception);
        Assert.That(() => p.CheckEvenOrThrow(57), Throws.Exception);
        Assert.That(() => p.CheckEvenOrThrow(999999999), Throws.Exception);
    }
}