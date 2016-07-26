namespace CarPlant
{
	public class SandBuggy : FourWheelDriveCar
	{
		private readonly FourWheelSteering _fourWheelSteering;

		public SandBuggy()
		{
			_fourWheelSteering = new FourWheelSteering(this);
		}

		public override string Name()
		{
			return "Sand Buggy";
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