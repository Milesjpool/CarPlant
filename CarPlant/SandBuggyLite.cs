namespace CarPlant
{
	public class SandBuggyLite : RearWheelDriveCar
	{
		public SandBuggyLite(WheelSet wheelSet, ISteeringMechanism steeringMechanism) : base(steeringMechanism, new RearWheelDrive(wheelSet))
		{
		}

		public override string Name()
		{
			return "Sand Buggy Lite";
		}
	}
}