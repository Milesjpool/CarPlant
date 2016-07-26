namespace CarPlant
{
	public class SandBuggyLite : RearWheelDriveCar
	{
		private readonly ISteeringMechanism _steeringMechanism;

		public SandBuggyLite(WheelSet wheelSet, ISteeringMechanism steeringMechanism)
			: base(wheelSet)
		{
			_steeringMechanism = steeringMechanism;
		}

		public override string Name()
		{
			return "Sand Buggy Lite";
		}

		public override void TurnLeft(int degrees)
		{
			_steeringMechanism.TurnLeft(degrees);
		}

		public override void TurnRight(int degrees)
		{
			_steeringMechanism.TurnRight(degrees);
		}
	}
}