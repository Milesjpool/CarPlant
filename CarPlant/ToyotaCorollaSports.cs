namespace CarPlant
{
	class ToyotaCorollaSports : Car
	{
		public ToyotaCorollaSports(WheelSet wheelSet) : base(new TwoWheelSteering(wheelSet), new RearWheelDrive(wheelSet))
		{
		}

		public override string Name()
		{
			return "Toyota Corolla sports";
		}
	}
}