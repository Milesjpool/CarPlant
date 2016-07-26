using NUnit.Framework;

namespace CarPlant.Tests
{
	[TestFixture]
	public class ToyotaCorollaSportsTest
	{

		private Car _corolla;

		[SetUp]
		public void Init()
		{
			CarPlant.Log = "";
			_corolla = CarPlant.MakeToyotaCorollaSports();
		}

		[Test]
		public void HasTheCorrectName()
		{
			Assert.AreEqual("Toyota Corolla sports", _corolla.Name());
		}

		[Test]
		public void TurningLeftOnlyTurnsTheFrontWheels()
		{
			var degrees = TestHelpers.randomDegrees();
			_corolla.TurnLeft(degrees);
			Assert.AreEqual("front left turning left " + degrees + " degrees\n"
			             + "front right turning left " + degrees + " degrees\n", CarPlant.Log);
		}

		[Test]
		public void TurningRightOnlyTurnsTheFrontWheels()
		{
			var degrees = TestHelpers.randomDegrees();
			_corolla.TurnRight(degrees);
			Assert.AreEqual("front left turning right " + degrees + " degrees\n"
			             + "front right turning right " + degrees + " degrees\n", CarPlant.Log);
		}

		[Test]
		public void AcceleratingOnlyTurnsTheRearWheels()
		{
			var speed = TestHelpers.randomSpeed();
			_corolla.Accelerate(speed);
			Assert.AreEqual("rear left accelerating " + speed + " kph\n"
			             + "rear right accelerating " + speed + " kph\n", CarPlant.Log);
		}

	}
}

