public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, float length, float speed) : base(date, length)
    {
        _speed = speed;
    }

    public override float CalculateDistance()
    {
        return (_speed * GetLength()) / 60;
    }

    public override float CalculateSpeed()
    {
        return _speed;
    }

    public override float CalculatePace()
    {
       return 60 / _speed;
    }
}