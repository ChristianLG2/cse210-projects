using System;

class CheckListGoal : Goal
{
    // Fields specific to CheckListGoal
    private int or_currentGoal;
    private int or_bonus;
    private int or_bonusPoint;

    // Constructor
    public CheckListGoal(string or_name, string or_description, int or_points, int bonus, int or_bonus_point) : base(or_name, or_description, or_points)
    {
        // Initialize fields specific to CheckListGoal
        or_bonus = bonus;
        or_bonusPoint = or_bonus_point;
    }

    // Override List method
    public override void List(int i)
    {
        if (or_isCompleted)
        {
            Console.WriteLine($"{i}. [X] {base.getName()} ({base.getDescription()}) -- Currently Completed: {or_currentGoal}/{or_bonus}");
        }
        else
        {
            Console.WriteLine($"{i}. [ ] {base.getName()} ({base.getDescription()}) -- Currently Completed: {or_currentGoal}/{or_bonus}");
        }
    }

    // Override Complete method
    public override int Complete()
    {
        if (or_isCompleted == false)
        {
            or_currentGoal += 1;
            if (or_currentGoal == or_bonus)
            {
                or_isCompleted = true;
                return base.getPoints() + or_bonusPoint;
            }
            else
            {
                return base.getPoints();
            }
        }
        else
        {
            return 0;
        }
    }

    // Override SaveFile method
    public override string SaveFile()
    {
        return $"CheckListGoal,{base.getName()},{base.getDescription()},{base.getPoints()},{or_isCompleted}, {or_currentGoal}, {or_bonusPoint}, {or_bonus}";
    }
}