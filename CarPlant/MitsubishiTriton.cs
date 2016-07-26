namespace CarPlant
{
	class MitsubishiTriton : Car
	{
		public MitsubishiTriton(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism) : base(steeringMechanism, driveMechanism)
		{
		}

		public override string Name()
		{
			return "Mitsubishi Triton";
		}
	}
}