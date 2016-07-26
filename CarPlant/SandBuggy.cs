namespace CarPlant
{
	public class SandBuggy : Car
	{
		public SandBuggy(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism)
			: base("Sand Buggy", steeringMechanism, driveMechanism)
		{
		}
	}
}