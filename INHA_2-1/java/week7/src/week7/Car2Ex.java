package week7;

public class Car2Ex {
	public static void main(String[] args) {
		Car2 myCar = new Car2("mustang", "black", 300);
		System.out.println("모델 : " + myCar.model);
		System.out.println("색상 : " + myCar.color);
		System.out.println("최고 속도 : " + myCar.maxSpeed);
	}
}
