namespace Geometric_Calculator.Models.Components;

public class Angle
{
    public double Radians { get; private set; }
    public double Degrees { get; private set; }

    public Angle(double radians = 0, double degrees = 0)
    {
        Radians = radians;
        Degrees = degrees;

        if (Degrees == 0) ConvertRadiansToDegrees();
        else if (Radians == 0) ConvertDegreesToRadians();
    }

    public void ConvertDegreesToRadians() => Radians = Degrees * Math.PI / 180;

    public void ConvertRadiansToDegrees() => Degrees = Radians / Math.PI * 180;
}