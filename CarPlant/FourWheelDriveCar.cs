namespace CarPlant {
	public abstract class FourWheelDriveCar : FrontWheelSteeringCar
	{
		public override void Accelerate(int kph)
		{
			FrontLeft.Rotate(kph);
			FrontRight.Rotate(kph);
			RearLeft.Rotate(kph);
			RearRight.Rotate(kph);
		}
	}
}