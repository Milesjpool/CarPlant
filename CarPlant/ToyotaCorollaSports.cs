namespace CarPlant
{
	class ToyotaCorollaSports : RearWheelDriveCar
	{
		public ToyotaCorollaSports(WheelSet wheelSet) : base(wheelSet, new TwoWheelSteering(wheelSet))
		{
		}

		public override string Name()
		{
			return "Toyota Corolla sports";
		}
	}
}