using Tyuiu.KoninDP.Lab2.Review.V13.Lib;

namespace Tyuiu.KoninDP.Lab2.Review.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            double[] valueWaitArray = new double[len];

            valueWaitArray[0] = 457.88;  // f(-5)
            valueWaitArray[1] = 295.06;  // f(-4)
            valueWaitArray[2] = 169.01;   // f(-3)
            valueWaitArray[3] = 80.58;   // f(-2)
            valueWaitArray[4] = 0;      // f(-1)
            valueWaitArray[5] = 2;     // f(0)
            valueWaitArray[6] = 0;      // f(1) (неопределено)
            valueWaitArray[7] = 80.58;  // f(2)
            valueWaitArray[8] = 169.01;  // f(3)
            valueWaitArray[9] = 295.06;  // f(4)
            valueWaitArray[10] = 457.88; // f(5)


            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}