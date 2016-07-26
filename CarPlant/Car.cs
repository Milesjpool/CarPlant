namespace CarPlant
{
	public abstract class Car
	{
		public abstract string Name ();

		private readonly ISteeringMechanism _steeringMechanism;
		private readonly IDriveMechanism _driveMechanism;

		protected Car(ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism)
		{
			_steeringMechanism = steeringMechanism;
			_driveMechanism = driveMechanism;
		}

		public void TurnLeft(int degrees)
		{
			_steeringMechanism.TurnLeft(degrees);
		}

		public void TurnRight(int degrees)
		{
			_steeringMechanism.TurnRight(degrees);
		}

		public void Accelerate(int kph)
		{
			_driveMechanism.Accelerate(kph);
		}
	}
}