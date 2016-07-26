namespace CarPlant
{
	public class FourWheelSteering
	{
		private readonly WheelSet _wheelSet;

		public FourWheelSteering(WheelSet wheelSet)
		{
			_wheelSet = wheelSet;
		}

		public void TurnLeft(int degrees)
		{
			_wheelSet.FrontLeft.TurnLeft(degrees);
			_wheelSet.FrontRight.TurnLeft(degrees);
			_wheelSet.RearLeft.TurnRight(degrees);
			_wheelSet.RearRight.TurnRight(degrees);
		}

		public void TurnRight(int degrees)
		{
			_wheelSet.FrontLeft.TurnRight(degrees);
			_wheelSet.FrontRight.TurnRight(degrees);
			_wheelSet.RearLeft.TurnLeft(degrees);
			_wheelSet.RearRight.TurnLeft(degrees);
		}
	}
}