namespace CarPlant
{
	public abstract class Car
	{
		public abstract string Name ();
		public abstract void Accelerate(int kmsPerHour);

		private readonly WheelSet _wheelSet;
		private readonly TwoWheelSteering _twoWheelSteering;

		protected Car(WheelSet wheelSet)
		{
			_wheelSet = wheelSet;
			_twoWheelSteering = new TwoWheelSteering(_wheelSet);
		}

		public virtual void TurnLeft(int degrees)
		{
			_twoWheelSteering.TurnLeftTwoWheels(degrees);
		}

		public virtual void TurnRight(int degrees)
		{
			_twoWheelSteering.TurnRightTwoWheels(degrees);
		}
	}
}