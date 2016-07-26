namespace CarPlant
{
	public class SandBuggyLite : Car
	{
		public SandBuggyLite(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism) : base(steeringMechanism, driveMechanism)
		{
		}

		public override string Name()
		{
			return "Sand Buggy Lite";
		}
	}
}