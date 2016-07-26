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
			return new MitsubishiTriton(new WheelSet());
		}

		public static Car MakeSandBuggy()
		{
			return new SandBuggy(new WheelSet());
		}

		public static Car MakeSandBuggyLite()
		{
			return new SandBuggyLite(new WheelSet());
		}
	}
}