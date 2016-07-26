namespace CarPlant
{
	public abstract class RearWheelDriveCar : Car
	{
		public override void Accelerate(int kph)
		{
			RearLeft.Rotate(kph);
			RearRight.Rotate(kph);
		}
	}
}