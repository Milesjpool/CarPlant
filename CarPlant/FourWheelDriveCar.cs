namespace CarPlant {
	public abstract class FourWheelDriveCar : Car
	{
		protected FourWheelDriveCar(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism)
			: base(steeringMechanism, driveMechanism)
		{
		}
	}
}