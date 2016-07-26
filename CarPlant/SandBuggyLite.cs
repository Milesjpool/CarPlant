namespace CarPlant
{
	public class SandBuggyLite : RearWheelDriveCar
	{
		public SandBuggyLite(WheelSet wheelSet, ISteeringMechanism steeringMechanism) : base(wheelSet, steeringMechanism)
		{
		}

		public override string Name()
		{
			return "Sand Buggy Lite";
		}
	}
}