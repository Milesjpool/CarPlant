namespace CarPlant
{
	abstract class FrontWheelDriveCar : Car
	{
		public override void Accelerate(int kph)
		{
			FrontLeft.Rotate(kph);
			FrontRight.Rotate(kph);
		}
	}
}