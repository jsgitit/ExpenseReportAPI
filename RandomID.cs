using System;
public static class RandomID
{
    public static long GetId(int maxnumber)
    {
        var id = new Random();
        return id.Next(1,maxnumber);
    }
}