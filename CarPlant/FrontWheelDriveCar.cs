namespace CarPlant
{
	abstract class FrontWheelDriveCar : Car
	{
		private readonly WheelSet _wheelSet;

		protected FrontWheelDriveCar(WheelSet wheelSet) : base(wheelSet)
		{
			_wheelSet = wheelSet;
		}

		public override void Accelerate(int kph)
		{
			_wheelSet.FrontLeft.Rotate(kph);
			_wheelSet.FrontRight.Rotate(kph);
		}
	}
}