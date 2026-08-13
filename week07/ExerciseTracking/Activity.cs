public abstract class Activity
{
    protected string _date;
    protected float _length;

    public string GetDate()
    {
        return _date;
    }

    public float GetLength()
    {
        return _length;
    }

    public void SetDate(string date)
    {
        _date = date;
    }
    
    public void SetLength(float length)
    {
        _length = length;
    }

    public Activity(string date, float length)
    {
        _date = date;
        _length = length;
    }

    public abstract float CalculateDistance();

    public abstract float CalculateSpeed();

    public abstract float CalculatePace();

    public virtual string GetSummary()
    {
        string activityName = GetType().Name;
        float distance = CalculateDistance();
        float speed = CalculateSpeed();
        float pace = CalculatePace();

        return $"{_date} {activityName} ({_length} min) - Distance {distance:F1} km, Speed {speed:F1} mph, Pace: {pace:F1} min per km";
    }
}