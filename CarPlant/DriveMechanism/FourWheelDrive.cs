namespace CarPlant.DriveMechanism
{
	public class FourWheelDrive : IDriveMechanism
	{
		private readonly WheelSet _wheelSet;

		public FourWheelDrive(WheelSet wheelSet)
		{
			_wheelSet = wheelSet;
		}

		public void Accelerate(int kph)
		{
			_wheelSet.FrontLeft.Rotate(kph);
			_wheelSet.FrontRight.Rotate(kph);
			_wheelSet.RearLeft.Rotate(kph);
			_wheelSet.RearRight.Rotate(kph);
		}
	}
}