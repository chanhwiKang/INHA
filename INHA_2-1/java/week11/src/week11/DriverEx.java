package week11;

public class DriverEx {
	public static void main(String[] args) {
		Driver d = new Driver();
		Vehicle v = new Vehicle();
		d.drive(v);
		
		Bus bus = new Bus();
		d.drive(bus);
		d.drive(new Taxi());
	}
}
