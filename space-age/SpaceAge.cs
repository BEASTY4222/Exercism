public class SpaceAge
{
    private double seconds;
    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        return (double)seconds / 31557600d;
    }

    public double OnMercury()
    {
        return (double)seconds / (31557600d * 0.2408467d);
    }

    public double OnVenus()
    {
        return (double)seconds / (31557600d * 0.61519726d);
    }

    public double OnMars()
    {
        return (double)seconds / (31557600d * 1.8808158d);
    }

    public double OnJupiter()
    {
        return (double)seconds / (31557600d * 11.862615d);
    }

    public double OnSaturn()
    {
        return (double)seconds / (31557600d * 29.447498d);
    }

    public double OnUranus()
    {
        return (double)seconds / (31557600d * 84.016846d);
    }

    public double OnNeptune()
    {
        return (double)seconds / (31557600d * 164.79132d);
    }
}