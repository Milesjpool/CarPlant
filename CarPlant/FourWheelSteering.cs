namespace CarPlant
{
	public class FourWheelSteering
	{
		private readonly Car _car;

		public FourWheelSteering(Car car)
		{
			_car = car;
		}

		public void TurnLeft(int degrees)
		{
			_car.FrontLeft.TurnLeft(degrees);
			_car.FrontRight.TurnLeft(degrees);
			_car.RearLeft.TurnRight(degrees);
			_car.RearRight.TurnRight(degrees);
		}

		public void TurnRight(int degrees)
		{
			_car.FrontLeft.TurnRight(degrees);
			_car.FrontRight.TurnRight(degrees);
			_car.RearLeft.TurnLeft(degrees);
			_car.RearRight.TurnLeft(degrees);
		}
	}
}