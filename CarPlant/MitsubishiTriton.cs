namespace CarPlant
{
	class MitsubishiTriton : Car
	{
		public MitsubishiTriton(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism) : base("Mitsubishi Triton", steeringMechanism, driveMechanism)
		{
		}
	}
}