public class Running : Activity
{
    private float _distance;

    public Running(string date, float length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override float CalculateDistance()
    {
        return _distance;
    }

    public override float CalculateSpeed()
    {
        return (_distance / GetLength()) * 60;
    }

    public override float CalculatePace()
    {
        return GetLength() / _distance;
    }
}