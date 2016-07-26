namespace CarPlant
{
	class ToyotaCorolla : Car
	{
		public ToyotaCorolla(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism) : base(steeringMechanism, driveMechanism)
		{
		}

		public override string Name()
		{
			return "Toyota Corolla";
		}
	}
}