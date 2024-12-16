namespace Tyuiu.KoninDP.Lab2.Review.V13.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = stopValue - startValue + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (double x = startValue; x <= stopValue; x++)
            {

                if (x == 1 || x == -1)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    y = Math.Cos(x) + Math.Pow((x + 1) / (x - 1), x) + 18 * Math.Pow(x, 2);
                    Console.WriteLine(y);
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}