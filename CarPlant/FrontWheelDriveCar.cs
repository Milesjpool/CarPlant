namespace CarPlant
{
	abstract class FrontWheelDriveCar : Car
	{
		private readonly WheelSet _wheelSet;
		private readonly FrontWheelDrive _frontWheelDrive;

		protected FrontWheelDriveCar(WheelSet wheelSet, ISteeringMechanism steeringMechanism) : base(steeringMechanism)
		{
			_wheelSet = wheelSet;
			_frontWheelDrive = new FrontWheelDrive(wheelSet);
		}

		public override void Accelerate(int kph)
		{
			_frontWheelDrive.Accelerate(kph);
		}
	}
}