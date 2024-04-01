using System;

public abstract class Goal
{
    protected int _pointValue;
    protected string _goalName;
    protected bool _ending;
    protected bool _complete;
    public Goal(int pointValue, string goalName) {
        _pointValue = pointValue;
        _goalName = goalName;

    }

    public string GetName() {
        return _goalName;
    }

    public int GetPoints() {
        return _pointValue;
    }

    public abstract bool GetStatus();
    public abstract void DisplayGoal();
    public abstract int MarkComplete();
    public abstract string Stringify();
}