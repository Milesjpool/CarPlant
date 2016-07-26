using CarPlant.DriveMechanism;

namespace CarPlant {
	public static class CarPlant
	{
		public static string Log;

		public static Car MakeToyotaCorolla()
		{
			var wheelSet = new WheelSet();
			return new Car("Toyota Corolla", new TwoWheelSteering(wheelSet), new FrontWheelDrive(wheelSet));
		}

		public static Car MakeToyotaCorollaSports()
		{
			var wheelSet = new WheelSet();
			return new Car("Toyota Corolla sports", new TwoWheelSteering(wheelSet), new RearWheelDrive(wheelSet));
		}

		public static Car MakeMitsubishiTriton()
		{
			var wheelSet = new WheelSet();
			return new Car("Mitsubishi Triton", new TwoWheelSteering(wheelSet), new FourWheelDrive(wheelSet));
		}

		public static Car MakeSandBuggy()
		{
			var wheelSet = new WheelSet();
			return new Car("Sand Buggy", new FourWheelSteering(wheelSet), new FourWheelDrive(wheelSet));
		}

		public static Car MakeSandBuggyLite()
		{
			var wheelSet = new WheelSet();
			return new Car("Sand Buggy Lite", new FourWheelSteering(wheelSet), new RearWheelDrive(wheelSet));
		}
	}
}