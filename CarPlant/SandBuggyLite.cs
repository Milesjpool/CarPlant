namespace CarPlant
{
	public class SandBuggyLite : RearWheelDriveCar
	{

		public override string Name()
		{
			return "Sand Buggy Lite";
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