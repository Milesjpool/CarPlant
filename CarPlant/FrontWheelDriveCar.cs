namespace CarPlant
{
	abstract class FrontWheelDriveCar : Car
	{
		private readonly IDriveMechanism _driveMechanism;

		protected FrontWheelDriveCar(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism)
			: base(steeringMechanism)
		{
			_driveMechanism = driveMechanism;
		}

		public override void Accelerate(int kph)
		{
			_driveMechanism.Accelerate(kph);
		}
	}
}