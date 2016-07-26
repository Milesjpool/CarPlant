namespace CarPlant
{
	class FrontWheelDrive
	{
		private readonly WheelSet _wheelSet;

		public FrontWheelDrive(WheelSet wheelSet)
		{
			_wheelSet = wheelSet;
		}

		public void Accelerate(int kph)
		{
			_wheelSet.FrontLeft.Rotate(kph);
			_wheelSet.FrontRight.Rotate(kph);
		}
	}
}