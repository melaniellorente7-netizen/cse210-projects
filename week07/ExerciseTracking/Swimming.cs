public class Swimming : Activity
{
    private int _number_laps;

    public Swimming (string date, float length, int laps) : base(date, length)
    {
        _number_laps = laps;
    }

    public override float CalculateDistance()
    {
        return _number_laps * 50 / 1000f;
    
    }

    public override float CalculatePace()
    {
        return GetLength() / CalculateDistance();
    }

    public override float CalculateSpeed()
    {
        return CalculateDistance()/ GetLength() * 60;
    }
}