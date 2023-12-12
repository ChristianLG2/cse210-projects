using System;

class Goal
{
    // Fields
    public bool or_isCompleted = false;
    private string or_name;
    private string or_description;
    private int or_point;

    // Constructor
    public Goal(string name, string description, int points)
    {
        or_name = name;
        or_point = points;
        or_description = description;
    }

    // Getter methods
    public string getName()
    {
        return or_name;
    }

    public string getDescription()
    {
        return or_description;
    }

    public int getPoints()
    {
        return or_point;
    }

    public bool getComplete()
    {
        return or_isCompleted;
    }

    // Virtual methods
    public virtual void List(int i)
    {
        // This method is intended to be overridden by derived classes
    }

    public virtual string SaveFile()
    {
        // This method is intended to be overridden by derived classes
        return "";
    }

    public virtual int Complete()
    {
        if (or_isCompleted == false)
        {
            or_isCompleted = true;
            return or_point;
        }
        else
        {
            return 0;
        }
    }
}