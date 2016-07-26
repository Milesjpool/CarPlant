namespace CarPlant
{
	public class RearWheelDrive : IDriveMechanism
	{
		private readonly WheelSet _wheelSet;

		public RearWheelDrive(WheelSet wheelSet)
		{
			_wheelSet = wheelSet;
		}

		public void Accelerate(int kph)
		{
			_wheelSet.RearLeft.Rotate(kph);
			_wheelSet.RearRight.Rotate(kph);
		}
	}
}