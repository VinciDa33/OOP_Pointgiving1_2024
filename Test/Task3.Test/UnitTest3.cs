namespace Task3.Test;

public class Tests
{
    [Test]
    public void Test1()
    {
        Program p = new Program();

        int[] arr1 = {5, 8};
        p.FlipPositions(arr1);
        Assert.IsTrue(arr1[0] == 8 && arr1[1] == 5);

        int[] arr2 = {108, 7};
        p.FlipPositions(arr2);
        Assert.IsTrue(arr2[0] == 7 && arr2[1] == 108);

        int[] arr3 = {5893, 2459};
        p.FlipPositions(arr3);
        Assert.IsTrue(arr3[0] == 2459 && arr3[1] == 5893);

        int[] arr4 = {1, 2};
        p.FlipPositions(arr4);
        Assert.IsTrue(arr4[0] == 2 && arr4[1] == 1);

        int[] arr5 = {-10, 10};
        p.FlipPositions(arr5);
        Assert.IsTrue(arr5[0] == 10 && arr5[1] == -10);

        int[] arr6 = {9999999, 0};
        p.FlipPositions(arr6);
        Assert.IsTrue(arr6[0] == 0 && arr6[1] == 9999999);

        int[] arr7 = {-100, -111};
        p.FlipPositions(arr7);
        Assert.IsTrue(arr7[0] == -111 && arr7[1] == -100);

        int[] arr8 = {7, 77};
        p.FlipPositions(arr8);
        Assert.IsTrue(arr8[0] == 77 && arr8[1] == 7);
    }
}