public class ActivityTracker
{
    public int DailyGoal { get; }
    public int StepsToday { get; private set; }

    public ActivityTracker(int dailyGoal)
    {
        DailyGoal = dailyGoal;
        StepsToday = 0;
    }
}
