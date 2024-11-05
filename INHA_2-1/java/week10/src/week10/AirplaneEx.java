package week10;

public class AirplaneEx {
	public static void main(String[] args) {
		SonicAirplane plane = new SonicAirplane();
		plane.takeOff();
		plane.fly();
		plane.land();
		
		plane.flymode = SonicAirplane.SUPERSONIC;
		plane.fly();
	}
}
