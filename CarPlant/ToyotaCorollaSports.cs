namespace CarPlant
{
	class ToyotaCorollaSports : Car
	{
		public ToyotaCorollaSports(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism) : base(steeringMechanism, driveMechanism)
		{
		}

		public override string Name()
		{
			return "Toyota Corolla sports";
		}
	}
}