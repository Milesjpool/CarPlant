using NUnit.Framework;

namespace CarPlant.Tests
{
	[TestFixture]
	public class MitsubishiTritonTest
	{
		private Car _triton;

		[SetUp]
		public void Init()
		{
			CarPlant.Log = "";
			_triton = CarPlant.MakeMitsubishiTriton();
		}

		[Test]
		public void HasTheCorrectName()
		{
			Assert.AreEqual("Mitsubishi Triton", _triton.Name());
		}

		[Test]
		public void TurningLeftOnlyTurnsTheFrontWheels()
		{
			var degrees = TestHelpers.randomDegrees();
			_triton.TurnLeft(degrees);
			Assert.AreEqual("front left turning left " + degrees + " degrees\n"
			             + "front right turning left " + degrees + " degrees\n", CarPlant.Log);
		}

		[Test]
		public void TurningRightOnlyTurnsTheFrontWheels()
		{
			var degrees = TestHelpers.randomDegrees();
			_triton.TurnRight(degrees);
			Assert.AreEqual("front left turning right " + degrees + " degrees\n"
			             + "front right turning right " + degrees + " degrees\n", CarPlant.Log);
		}

		[Test]
		public void AcceleratingTurnsAllWheels()
		{
			var speed = TestHelpers.randomSpeed();
			_triton.Accelerate(speed);
			Assert.AreEqual("front left accelerating " + speed + " kph\n"
			             + "front right accelerating " + speed + " kph\n"
			             + "rear left accelerating " + speed + " kph\n"
			             + "rear right accelerating " + speed + " kph\n", CarPlant.Log);
		}

	}
}

