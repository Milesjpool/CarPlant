namespace CarPlant
{
	public abstract class Car
	{
		public abstract string Name ();
		public abstract void Accelerate(int kmsPerHour);

		private readonly WheelSet _wheelSet;

		protected Car(WheelSet wheelSet)
		{
			_wheelSet = wheelSet;
		}

		public virtual void TurnLeft(int degrees)
		{
			_wheelSet.FrontLeft.TurnLeft(degrees);
			_wheelSet.FrontRight.TurnLeft(degrees);
		}

		public virtual void TurnRight(int degrees)
		{
			_wheelSet.FrontLeft.TurnRight(degrees);
			_wheelSet.FrontRight.TurnRight(degrees);
		}
	}
}