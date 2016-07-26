namespace CarPlant
{
	public abstract class RearWheelDriveCar : Car
	{
		protected RearWheelDriveCar(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism)
			: base(steeringMechanism, driveMechanism)
		{
		}
	}
}