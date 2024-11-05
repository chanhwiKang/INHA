package week9;

public class Car {
	int speed;
	void run() {
		System.out.println("시속 " + speed+ "km로 달립니다.");
	}
	// main method도 정적 메소드이므로 객체 생성없이 실행이 가능.
	public static void main(String[] args) {
		// speed = 10;
		// 객체를 만들면 인스턴스 멤버에 접근 가능.
		Car mycar = new Car();
		mycar.speed = 100;
		mycar.run();
		
	}
}
