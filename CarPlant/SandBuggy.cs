namespace CarPlant
{
	public class SandBuggy : FourWheelDriveCar
	{
		private readonly ISteeringMechanism _steeringMechanism;

		public SandBuggy(WheelSet wheelSet, ISteeringMechanism steeringMechanism)
			: base(wheelSet)
		{
			_steeringMechanism = steeringMechanism;
		}

		public override string Name()
		{
			return "Sand Buggy";
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