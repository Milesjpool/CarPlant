namespace CarPlant
{
	class MitsubishiTriton : FourWheelDriveCar
	{
		public MitsubishiTriton(WheelSet wheelSet) : base(wheelSet)
		{
		}

		public override string Name()
		{
			return "Mitsubishi Triton";
		}
	}
}