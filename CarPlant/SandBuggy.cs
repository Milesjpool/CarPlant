namespace CarPlant
{
	public class SandBuggy : FourWheelDriveCar
	{
		public override string Name()
		{
			return "Sand Buggy";
		}

		public override void TurnLeft(int degrees)
		{
			FrontLeft.TurnLeft(degrees);
			FrontRight.TurnLeft(degrees);
			RearLeft.TurnRight(degrees);
			RearRight.TurnRight(degrees);
		}

		public override void TurnRight(int degrees)
		{
			FrontLeft.TurnRight(degrees);
			FrontRight.TurnRight(degrees);
			RearLeft.TurnLeft(degrees);
			RearRight.TurnLeft(degrees);
		}
	}
}