namespace CarPlant {
	public class CarPlant
	{
		public static string Log;

		public static FrontWheelSteeringCar MakeToyotaCorolla()
		{
			return new ToyotaCorolla();
		}

		public static FrontWheelSteeringCar MakeToyotaCorollaSports()
		{
			return new ToyotaCorollaSports();
		}

		public static FrontWheelSteeringCar MakeMitsubishiTriton()
		{
			return new MitsubishiTriton();
		}

		public static FrontWheelSteeringCar MakeSandBuggy()
		{
			return new SandBuggy();
		}

		public static FrontWheelSteeringCar MakeSandBuggyLite()
		{
			return new SandBuggyLite();
		}
	}
}