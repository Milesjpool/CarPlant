using NUnit.Framework;

namespace CarPlant.Tests
{
	[TestFixture]
	public class SandBuggyTest
	{
		private Car _buggy;

		[SetUp]
		public void Init()
		{
			CarPlant.Log = "";
			_buggy = CarPlant.MakeSandBuggy();
		}

		[Test]
		public void HasTheCorrectName()
		{
			Assert.AreEqual("Sand Buggy", _buggy.Name());
		}

		[Test]
		public void TurningLeftTurnsAllWheels()
		{
			var degrees = TestHelpers.randomDegrees();
			_buggy.TurnLeft(degrees);
			Assert.AreEqual("front left turning left " + degrees + " degrees\n"
			             + "front right turning left " + degrees + " degrees\n"
			             + "rear left turning right " + degrees + " degrees\n"
			             + "rear right turning right " + degrees + " degrees\n", CarPlant.Log);
		}

		[Test]
		public void TurningRightTurnsAllWheels()
		{
			var degrees = TestHelpers.randomDegrees();
			_buggy.TurnRight(degrees);
			Assert.AreEqual("front left turning right " + degrees + " degrees\n"
			             + "front right turning right " + degrees + " degrees\n"
			             + "rear left turning left " + degrees + " degrees\n"
			             + "rear right turning left " + degrees + " degrees\n", CarPlant.Log);
		}

		[Test]
		public void AcceleratingTurnsAllWheels()
		{
			var speed = TestHelpers.randomSpeed();
			_buggy.Accelerate(speed);
			Assert.AreEqual("front left accelerating " + speed + " kph\n"
			             + "front right accelerating " + speed + " kph\n"
			             + "rear left accelerating " + speed + " kph\n"
			             + "rear right accelerating " + speed + " kph\n", CarPlant.Log);
		}

	}
}

