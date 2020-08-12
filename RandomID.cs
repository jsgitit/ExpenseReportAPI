using System;
public static class RandomID
{
    public static long GetId(int maxNumber)
    {
        var id = new Random();
        return id.Next(1, maxNumber);
    }

    public static long GetIdBetween(int minNumber, int maxNumber)
    {
        var id = new Random();
        return id.Next(minNumber, maxNumber);
    }
}