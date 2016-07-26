namespace CarPlant
{
	public class SandBuggy : FourWheelDriveCar
	{
		private readonly FourWheelSteering _steeringMechanism;

		public SandBuggy(WheelSet wheelSet) : base(wheelSet)
		{
			_steeringMechanism = new FourWheelSteering(wheelSet);
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