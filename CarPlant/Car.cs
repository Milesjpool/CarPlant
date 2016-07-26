namespace CarPlant
{
	public class Car
	{
		private readonly ISteeringMechanism _steeringMechanism;
		private readonly IDriveMechanism _driveMechanism;
		private readonly string _name;

		public Car(string name, ISteeringMechanism steeringMechanism, IDriveMechanism driveMechanism)
		{
			_name = name;
			_steeringMechanism = steeringMechanism;
			_driveMechanism = driveMechanism;
		}

		public string Name()
		{
			return _name;
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