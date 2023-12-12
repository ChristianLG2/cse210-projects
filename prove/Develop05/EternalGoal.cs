using System;

class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string or_name, string or_description, int or_points) : base(or_name, or_description, or_points)
    {
        // The constructor of the base class (Goal) is called with specified parameters
    }

    // Override List method
    public override void List(int i)
    {
        Console.WriteLine($"{i}. [ ] {base.getName()} ({base.getDescription()})");
        // This displays the eternal goal information in a specific format
    }

    // Override Complete method
    public override int Complete()
    {
        return base.getPoints();
        // Completing an eternal goal returns its base points without any additional logic
    }

    // Override SaveFile method
    public override string SaveFile()
    {
        return $"EternalGoal,{base.getName()},{base.getDescription()},{base.getPoints()},{or_isCompleted}";
        // This returns a string representation of the eternal goal for saving to a file
    }
}
