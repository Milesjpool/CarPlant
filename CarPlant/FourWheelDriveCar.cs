namespace CarPlant {
	public abstract class FourWheelDriveCar : Car
	{
		private readonly IDriveMechanism _fourWheelDrive;

		protected FourWheelDriveCar(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism)
			: base(steeringMechanism)
		{
			_fourWheelDrive = driveMechanism;
		}

		public override void Accelerate(int kph)
		{
			_fourWheelDrive.Accelerate(kph);
		}
	}
}