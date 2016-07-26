namespace CarPlant
{
	public class SandBuggyLite : RearWheelDriveCar
	{
		private readonly FourWheelSteering _steeringMechanism;

		public SandBuggyLite()
		{
			_steeringMechanism = new FourWheelSteering(this);
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