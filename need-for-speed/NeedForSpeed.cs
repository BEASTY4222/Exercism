class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed;
    private int batteryDrain;
    private int distanceDriven;
    private int battery;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        distanceDriven = 0;
        battery = 100;
    }

    public bool BatteryDrained()
    {
        return battery <= 0 || battery - batteryDrain < 0;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if(!BatteryDrained())
        {
            battery -= batteryDrain;
            distanceDriven += speed;    
        }
        else return;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;
    public RaceTrack(int distance){ this.distance = distance; } 

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(car.DistanceDriven() <= distance && !car.BatteryDrained()) car.Drive();
        return car.DistanceDriven() >= distance;
    }
}
