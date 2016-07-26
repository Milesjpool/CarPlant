namespace CarPlant
{
	public class SandBuggy : Car
	{
		public SandBuggy(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism)
			: base(steeringMechanism, driveMechanism)
		{
		}

		public override string Name()
		{
			return "Sand Buggy";
		}
	}
}