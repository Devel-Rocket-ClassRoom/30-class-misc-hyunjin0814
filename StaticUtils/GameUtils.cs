static class GameUtils
{ 
    public static int Clamp(int value, int min, int max)
    {
        if (value < min)
        {
            value = min;
        }
        if (value > max)
        {
            value = max; 
        }

        return value;
    }

    public static double GetPercentage(int current, int max)
    {
        double rate = (double)current * 100 / max;

        return rate;
    }

    public static bool IsInRange(int value, int min, int max)
    {
        bool isInRange = false;

        if (value >= min && value <= max)
        {
            isInRange = true;
        }

        return isInRange;
    }
}