namespace CarPlant
{
	public abstract class RearWheelDriveCar : Car
	{
		private readonly WheelSet _wheelSet;

		protected RearWheelDriveCar(WheelSet wheelSet, ISteeringMechanism steeringMechanism) : base(steeringMechanism)
		{
			_wheelSet = wheelSet;
		}

		public override void Accelerate(int kph)
		{
			_wheelSet.RearLeft.Rotate(kph);
			_wheelSet.RearRight.Rotate(kph);
		}
	}
}