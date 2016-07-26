namespace CarPlant
{
	public abstract class Car
	{
		public abstract string Name ();
		public abstract void Accelerate(int kmsPerHour);

		public Wheel FrontLeft;
		public Wheel FrontRight;
		public Wheel RearLeft;
		public Wheel RearRight;

		protected Car()
		{
			FrontLeft = new Wheel("front left");
			FrontRight = new Wheel("front right");
			RearLeft = new Wheel("rear left");
			RearRight = new Wheel("rear right");
		}

		public virtual void TurnLeft(int degrees)
		{
			FrontLeft.TurnLeft(degrees);
			FrontRight.TurnLeft(degrees);
		}

		public virtual void TurnRight(int degrees)
		{
			FrontLeft.TurnRight(degrees);
			FrontRight.TurnRight(degrees);
		}
	}
}