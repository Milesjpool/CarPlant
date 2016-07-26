namespace CarPlant
{
	public abstract class Car
	{
		public abstract string Name ();
		public abstract void Accelerate(int kmsPerHour);

		private readonly TwoWheelSteering _steeringMechanism;

		protected Car(TwoWheelSteering twoWheelSteering)
		{
			_steeringMechanism = twoWheelSteering;
		}

		public virtual void TurnLeft(int degrees)
		{
			_steeringMechanism.TurnLeft(degrees);
		}

		public virtual void TurnRight(int degrees)
		{
			_steeringMechanism.TurnRight(degrees);
		}
	}
}