namespace CarPlant
{
	public class SandBuggy : FourWheelDriveCar
	{
		public SandBuggy(WheelSet wheelSet, ISteeringMechanism steeringMechanism)
			: base(steeringMechanism, new FourWheelDrive(wheelSet))
		{
		}

		public override string Name()
		{
			return "Sand Buggy";
		}
	}
}