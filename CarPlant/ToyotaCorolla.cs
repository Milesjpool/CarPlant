namespace CarPlant
{
	class ToyotaCorolla : Car
	{
		public ToyotaCorolla(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism) : base("Toyota Corolla", steeringMechanism, driveMechanism)
		{
		}
	}
}