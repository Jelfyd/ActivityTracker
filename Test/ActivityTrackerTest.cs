using Xunit;

public class ActivityTrackerTests
{
    [Fact]
    public void Constructor_ShouldThrowException_WhenDailyGoalIsNegative()
    {
        Assert.Throws<ArgumentException>(() => new ActivityTracker(-5));
    }

    [Fact]
    public void AddSteps_ShouldIncreaseSteps()
    {
        var tracker = new ActivityTracker(10000);

        tracker.AddSteps(500);

        Assert.Equal(500, tracker.StepsToday);
    }

    [Fact]
    public void ResetDay_ShouldSetStepsToZero()
    {
        var tracker = new ActivityTracker(5000);
        tracker.AddSteps(2000);

        tracker.ResetDay();

        Assert.Equal(0, tracker.StepsToday);
    }

    [Fact]
    public void GetProgress_ShouldReturnCorrectPercentage()
    {
        var tracker = new ActivityTracker(10000);
        tracker.AddSteps(2500);

        int progress = tracker.GetProgress();

        Assert.Equal(25, progress);
    }

    [Fact]
    public void IsGoalReached_ShouldBeTrue_WhenStepsExceedGoal()
    {
        var tracker = new ActivityTracker(3000);
        tracker.AddSteps(4000);

        Assert.True(tracker.IsGoalReached);
    }
}
