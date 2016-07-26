namespace CarPlant
{
	class MitsubishiTriton : FourWheelDriveCar
	{
		public MitsubishiTriton(WheelSet wheelSet, ISteeringMechanism steeringMechanism) : base(wheelSet, steeringMechanism)
		{
		}

		public override string Name()
		{
			return "Mitsubishi Triton";
		}
	}
}