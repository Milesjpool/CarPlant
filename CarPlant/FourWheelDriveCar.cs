namespace CarPlant {
	public abstract class FourWheelDriveCar : Car
	{
		private readonly WheelSet _wheelSet;

		protected FourWheelDriveCar(WheelSet wheelSet, ISteeringMechanism steeringMechanism) : base(steeringMechanism)
		{
			_wheelSet = wheelSet;
		}

		public override void Accelerate(int kph)
		{
			_wheelSet.FrontLeft.Rotate(kph);
			_wheelSet.FrontRight.Rotate(kph);
			_wheelSet.RearLeft.Rotate(kph);
			_wheelSet.RearRight.Rotate(kph);
		}
	}
}