namespace CarPlant
{
	public class SandBuggy : FourWheelDriveCar
	{
		public SandBuggy(WheelSet wheelSet, ISteeringMechanism steeringMechanism)
			: base(wheelSet, steeringMechanism)
		{
		}

		public override string Name()
		{
			return "Sand Buggy";
		}
	}
}