namespace CarPlant
{
	public class WheelSet
	{
		public readonly Wheel FrontLeft;
		public readonly Wheel FrontRight;
		public readonly Wheel RearLeft;
		public readonly Wheel RearRight;
		
		public WheelSet()
		{
			FrontLeft = new Wheel("front left");
			FrontRight = new Wheel("front right");
			RearLeft = new Wheel("rear left");
			RearRight = new Wheel("rear right");
		}
	}
}