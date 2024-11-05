package week7;

public class Car3Ex {
	public static void main(String[] args) {
		Car2 c1 = new Car2();
		System.out.printf("%s %s %d\n", c1.model, c1.color, c1.maxSpeed);
		Car2 c2 = new Car2("mustang");
		System.out.printf("%s %s %d\n", c2.model, c2.color, c2.maxSpeed);
		Car2 c3 = new Car2("morning", "black");
		System.out.printf("%s %s %d\n", c3.model, c3.color, c3.maxSpeed);
		Car2 c4 = new Car2("spark", "red", 90);
		System.out.printf("%s %s %d\n", c4.model, c4.color, c4.maxSpeed);
	}
	
}
