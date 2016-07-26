namespace CarPlant
{
	class ToyotaCorolla : FrontWheelDriveCar
	{
		public ToyotaCorolla(WheelSet wheelSet) : base(wheelSet, new TwoWheelSteering(wheelSet))
		{
		}

		public override string Name()
		{
			return "Toyota Corolla";
		}
	}
}