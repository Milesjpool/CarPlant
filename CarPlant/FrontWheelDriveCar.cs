namespace CarPlant
{
	abstract class FrontWheelDriveCar : FrontWheelSteeringCar
	{
		public override void Accelerate(int kph)
		{
			FrontLeft.Rotate(kph);
			FrontRight.Rotate(kph);
		}
	}
}