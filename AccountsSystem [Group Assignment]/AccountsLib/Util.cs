using AccountsLib;
using System;

public static class Util
{
    private static Random random = new Random();
    private static DayTime currentTime = new DayTime(105375);

    public static DayTime Now
    {
        get
        {
            currentTime += random.Next(100);
            return currentTime;
        }
    }
}
