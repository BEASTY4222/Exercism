class RemoteControlCar
{
    private int _battery = 100;
    private int _distanceDriven = 0;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return "Driven "+ _distanceDriven +" meters";
    }

    public string BatteryDisplay()
    {
        string result;
        if(_battery == 0) result = "Battery empty";
        else result = "Battery at "+ _battery +"%";

        return result;
    }

    public void Drive()
    {
        if (_battery > 0)
        {
            _battery -= 1;
            _distanceDriven += 20;
        }
        
    }
}
