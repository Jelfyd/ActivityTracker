public class ActivityTracker
{
    public int DailyGoal { get; }
    public int StepsToday { get; private set; }

    public ActivityTracker(int dailyGoal)
    {
        DailyGoal = dailyGoal;
        StepsToday = 0;
    }

    public void AddSteps(int steps)
    {
        if (steps > 0)
            StepsToday += steps;
    }

    public void ResetDay()
    {
        StepsToday = 0;
    }

}
