namespace CarPlant
{
	public class TwoWheelSteering : ISteeringMechanism
	{
		private readonly WheelSet _wheelSet;

		public TwoWheelSteering(WheelSet wheelSet)
		{
			_wheelSet = wheelSet;
		}

		public void TurnLeft(int degrees)
		{
			_wheelSet.FrontLeft.TurnLeft(degrees);
			_wheelSet.FrontRight.TurnLeft(degrees);
		}

		public void TurnRight(int degrees)
		{
			_wheelSet.FrontLeft.TurnRight(degrees);
			_wheelSet.FrontRight.TurnRight(degrees);
		}
	}
}