namespace CarPlant {
	public class CarPlant
	{
		public static string Log;

		public static Car MakeToyotaCorolla()
		{
			return new ToyotaCorolla();
		}

		public static Car MakeToyotaCorollaSports()
		{
			return new ToyotaCorollaSports();
		}

		public static Car MakeMitsubishiTriton()
		{
			return new MitsubishiTriton();
		}

		public static Car MakeSandBuggy()
		{
			return new SandBuggy();
		}

		public static Car MakeSandBuggyLite()
		{
			return new SandBuggyLite();
		}
	}
}