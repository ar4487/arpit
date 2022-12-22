abstract class MotorVehicle
{
    public string visibility = " Preparing for Drive";
    public abstract string DriveVehicle();
    public abstract string DriveStatus { get; }
}
class TwoWheeler : MotorVehicle
{
    public new string visibility;
    public TwoWheeler()
    {
        visibility = " Preparing for Drive";
    }
    public override string DriveStatus { get { return visibility; } }

    public override string DriveVehicle()
    {
        return "You are Driving two Wheeler";
    }

    class FourWheeler : MotorVehicle
    {
        public FourWheeler()
        {
            visibility = " Preparing for Drive";
        }
        public override string DriveStatus { get { return visibility; } }

        public override string DriveVehicle()
        {
            return "You are Driving four Wheeler";

        }
    }


        class Source
        {
            static void Main1234334(string[] args)
            {
               
            }
        }
    }