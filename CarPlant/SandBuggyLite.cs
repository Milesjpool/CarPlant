namespace CarPlant
{
	public class SandBuggyLite : RearWheelDriveCar
	{
		private readonly FourWheelSteering _fourWheelSteering;

		public SandBuggyLite()
		{
			_fourWheelSteering = new FourWheelSteering(this);
		}

		public override string Name()
		{
			return "Sand Buggy Lite";
		}

		public override void TurnLeft(int degrees)
		{
			_fourWheelSteering.TurnLeft(degrees);
		}

		public override void TurnRight(int degrees)
		{
			_fourWheelSteering.TurnRight(degrees);
		}
	}
}