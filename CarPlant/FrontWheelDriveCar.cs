namespace CarPlant
{
	abstract class FrontWheelDriveCar : Car
	{
		protected FrontWheelDriveCar(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism)
			: base(steeringMechanism, driveMechanism)
		{
		}
	}
}