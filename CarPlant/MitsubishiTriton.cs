namespace CarPlant
{
	class MitsubishiTriton : FourWheelDriveCar
	{
		public MitsubishiTriton(WheelSet wheelSet, ISteeringMechanism steeringMechanism) : base(steeringMechanism, new FourWheelDrive(wheelSet))
		{
		}

		public override string Name()
		{
			return "Mitsubishi Triton";
		}
	}
}