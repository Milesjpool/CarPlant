namespace CarPlant
{
	public abstract class RearWheelDriveCar : FrontWheelSteeringCar
	{
		public override void Accelerate(int kph)
		{
			RearLeft.Rotate(kph);
			RearRight.Rotate(kph);
		}
	}
}