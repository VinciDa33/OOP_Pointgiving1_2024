namespace Task1.Test;

public class Tests
{
    [Test]
    public void Test1()
    {
        Program p = new Program();
        Assert.IsTrue(p.SumOfArray(new int[] {5, 8}) == 13);
        Assert.IsTrue(p.SumOfArray(new int[] {112, 57, 2, 43}) == 214);
        Assert.IsTrue(p.SumOfArray(new int[] {15, 5}) == 20);
        Assert.IsTrue(p.SumOfArray(new int[] {45, 15, 40}) == 100);
        Assert.IsTrue(p.SumOfArray(new int[] {7, 9, 13}) == 29);
        Assert.IsTrue(p.SumOfArray(new int[] {3, 6, 11, 9}) == 29);
        Assert.IsTrue(p.SumOfArray(new int[] {100, 1, 1, 1}) == 103);
        Assert.IsTrue(p.SumOfArray(new int[] {54, 22}) == 76);
        Assert.IsTrue(p.SumOfArray(new int[] {18, 9, 3}) == 30);
        Assert.IsTrue(p.SumOfArray(new int[] {2, 3, 5, 10}) == 20);
        Assert.IsTrue(p.SumOfArray(new int[] {200, 100, 50, 25, 25}) == 400);
        Assert.IsTrue(p.SumOfArray(new int[] {99, 21}) == 120);
        Assert.IsTrue(p.SumOfArray(new int[] {12, 34, 2}) == 48);
        Assert.IsTrue(p.SumOfArray(new int[] {150, 75, 25}) == 250);
        Assert.IsTrue(p.SumOfArray(new int[] {80, 120}) == 200);
        Assert.IsTrue(p.SumOfArray(new int[] {1, 2, 3, 4, 5, 6, 7}) == 28);
        Assert.IsTrue(p.SumOfArray(new int[] {500, 400, 100}) == 1000);
        Assert.IsTrue(p.SumOfArray(new int[] {22, 28}) == 50);
        Assert.IsTrue(p.SumOfArray(new int[] {77, 23}) == 100);
        Assert.IsTrue(p.SumOfArray(new int[] {61, 39, 1, 1, 1, 1, 1}) == 105);
        Assert.IsTrue(p.SumOfArray(new int[] {14, 1, 3}) == 18);
        Assert.IsTrue(p.SumOfArray(new int[] {99, 0, 1}) == 100);
        Assert.IsTrue(p.SumOfArray(new int[] {9, 12, 15, 9}) == 45);
        Assert.IsTrue(p.SumOfArray(new int[] {300, 200, 500}) == 1000);
        Assert.IsTrue(p.SumOfArray(new int[] {31, 14, 5}) == 50);
        Assert.IsTrue(p.SumOfArray(new int[] {37, 12, 6, 5}) == 60);
    }
}