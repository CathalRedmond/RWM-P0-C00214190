using System.Collections.Generic;

public class RunningTotalFilter
{
    public static List<int> runningTotal(List<int> inputNumbers)
    {
        List<int> result = new List<int>();
        int runningTotal = 0;
        foreach(int number in inputNumbers)
        {
            runningTotal += number;
            result.Add(runningTotal);
        }
        return result;
    }
}
