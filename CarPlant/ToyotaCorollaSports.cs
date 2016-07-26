namespace CarPlant
{
	class ToyotaCorollaSports : RearWheelDriveCar
	{
		public ToyotaCorollaSports(WheelSet wheelSet) : base(wheelSet)
		{
		}

		public override string Name()
		{
			return "Toyota Corolla sports";
		}
	}
}