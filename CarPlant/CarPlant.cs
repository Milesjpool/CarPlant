namespace CarPlant {
	public static class CarPlant
	{
		public static string Log;

		public static Car MakeToyotaCorolla()
		{
			var wheelSet = new WheelSet();
			return new ToyotaCorolla(new TwoWheelSteering(wheelSet), new FrontWheelDrive(wheelSet));
		}

		public static Car MakeToyotaCorollaSports()
		{
			var wheelSet = new WheelSet();
			return new ToyotaCorollaSports(new TwoWheelSteering(wheelSet), new RearWheelDrive(wheelSet));
		}

		public static Car MakeMitsubishiTriton()
		{
			var wheelSet = new WheelSet();
			return new MitsubishiTriton(new TwoWheelSteering(wheelSet), new FourWheelDrive(wheelSet));
		}

		public static Car MakeSandBuggy()
		{
			var wheelSet = new WheelSet();
			return new SandBuggy(new FourWheelSteering(wheelSet), new FourWheelDrive(wheelSet));
		}

		public static Car MakeSandBuggyLite()
		{
			var wheelSet = new WheelSet();
			return new SandBuggyLite(new FourWheelSteering(wheelSet), new RearWheelDrive(wheelSet));
		}
	}
}