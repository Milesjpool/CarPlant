namespace CarPlant {

	public class Wheel {

		private readonly string _name;

		public Wheel(string name) {
			_name = name;
		}

		public void TurnLeft(int degrees) {
			CarPlant.Log += _name + " turning left " + degrees + " degrees\n";
		}

		public void TurnRight(int degrees) {
			CarPlant.Log += _name + " turning right " + degrees + " degrees\n";
		}

		public void Rotate(int kph) {
			CarPlant.Log += _name + " accelerating " + kph + " kph\n";
		}

	}
}