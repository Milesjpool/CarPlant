namespace CarPlant
{
	public class TwoWheelSteering
	{
		private readonly WheelSet _wheelSet;

		public TwoWheelSteering(WheelSet wheelSet)
		{
			_wheelSet = wheelSet;
		}

		public void TurnLeftTwoWheels(int degrees)
		{
			_wheelSet.FrontLeft.TurnLeft(degrees);
			_wheelSet.FrontRight.TurnLeft(degrees);
		}

		public void TurnRightTwoWheels(int degrees)
		{
			_wheelSet.FrontLeft.TurnRight(degrees);
			_wheelSet.FrontRight.TurnRight(degrees);
		}
	}
}