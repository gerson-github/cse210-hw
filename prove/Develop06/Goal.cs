using System;
using System.Collections.Generic;
using System.IO;

// Base Goal class
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;


    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public virtual string GetGoalName()
    {
        return _shortName;
    }

    public virtual int GetPoint()
    {
        return _points;
    }

    public virtual string GetDescription()
    {
        return _description;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        
        return $"[ {(IsComplete() ? "X" : " ")} ] {_shortName} - {_description} ({_points} points)";
        
        // string checkbox = "[ ]";
        // return $"{checkbox} {_shortName} ({_description})";

    }
    public abstract string GetStringRepresentation();
}
