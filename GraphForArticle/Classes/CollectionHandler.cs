namespace GraphForArticle
{
    static class CollectionHandler
    {
        public static void FindMinMax(double[,] tableXY, out double xMin, out double xMax, out double yMin, out double yMax)
        {
            xMin = double.MaxValue;
            xMax = double.MinValue;
            yMin = double.MaxValue;
            yMax = double.MinValue;

            for (int i = 0; i < tableXY.GetLength(0); i++)
            {
                if (xMin > tableXY[i, 0])
                    xMin = tableXY[i, 0];

                if (xMax < tableXY[i, 0])
                    xMax = tableXY[i, 0];

                for (int j = 1; j < tableXY.GetLength(1); j++)
                {
                    if (yMin > tableXY[i, j])
                        yMin = tableXY[i, j];

                    if (yMax < tableXY[i, j])
                        yMax = tableXY[i, j];
                }
            }
        }
    }
}
