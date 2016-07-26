namespace CarPlant
{
	class ToyotaCorolla : FrontWheelDriveCar
	{
		public ToyotaCorolla(WheelSet wheelSet) : base(new TwoWheelSteering(wheelSet), new FrontWheelDrive(wheelSet))
		{
		}

		public override string Name()
		{
			return "Toyota Corolla";
		}
	}
}