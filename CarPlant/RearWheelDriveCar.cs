namespace CarPlant
{
	public abstract class RearWheelDriveCar : Car
	{
		private readonly IDriveMechanism _rearWheelDrive;

		protected RearWheelDriveCar(ISteeringMechanism steeringMechanism, IDriveMechanism rearWheelDrive) : base(steeringMechanism)
		{
			_rearWheelDrive = rearWheelDrive;
		}

		public override void Accelerate(int kph)
		{
			_rearWheelDrive.Accelerate(kph);
		}
	}
}