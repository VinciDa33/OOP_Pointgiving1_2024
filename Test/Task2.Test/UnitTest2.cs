namespace Task2.Test;


public class Tests
{
    [Test]
    public void TestPositiveNumber()
    {
        Program p = new Program();
        Assert.IsTrue(p.MultiplyAndReturn(2) == 4);
        Assert.IsTrue(p.MultiplyAndReturn(35) == 70);
        Assert.IsTrue(p.MultiplyAndReturn(10) == 20);
        Assert.IsTrue(p.MultiplyAndReturn(102) == 204);
    }

    [Test]
    public void TestNegativeNumbers()
    {
        Program p = new Program();
        Assert.IsTrue(p.MultiplyAndReturn(-2) == -4);
        Assert.IsTrue(p.MultiplyAndReturn(-6) == -12);
        Assert.IsTrue(p.MultiplyAndReturn(-177) == -354);
        Assert.IsTrue(p.MultiplyAndReturn(-10) == -20);

    }

    [Test]
    public void TestMultiplyByZero()
    {
        Program p = new Program();
        Assert.IsTrue(p.MultiplyAndReturn(0) == 0);
    }
}