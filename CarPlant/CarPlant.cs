namespace CarPlant {
	public static class CarPlant
	{
		public static string Log;

		public static Car MakeToyotaCorolla()
		{
			return new ToyotaCorolla(new WheelSet());
		}

		public static Car MakeToyotaCorollaSports()
		{
			return new ToyotaCorollaSports(new WheelSet());
		}

		public static Car MakeMitsubishiTriton()
		{
			WheelSet wheelSet = new WheelSet();
			return new MitsubishiTriton(wheelSet, new TwoWheelSteering(wheelSet));
		}

		public static Car MakeSandBuggy()
		{
			var wheelSet = new WheelSet();
			return new SandBuggy(wheelSet, new FourWheelSteering(wheelSet));
		}

		public static Car MakeSandBuggyLite()
		{
			var wheelSet = new WheelSet();
			return new SandBuggyLite(wheelSet, new FourWheelSteering(wheelSet));
		}
	}
}