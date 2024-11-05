package week11;

public class CarEx {
	public static void main(String[] args) {
		Car car = new Car();
		
		car.tire = new Tire(); // 부모 클래스 객체
		car.run();
		
		car.tire = new Hangook(); // 자식 클래스 객체를 자동 타입 변환
		car.run();

		car.tire = new Kumho();
		car.run();
		System.out.println("=====================");
		
		// 여러개의 차 객체를 생성
		Car[] cars = new Car[3];
		for(int i=0; i<cars.length; i++) 
			cars[i] = new Car();
		cars[0].tire = new Tire();
		cars[1].tire = new Hangook();
		cars[2].tire = new Kumho();
		for(int i=0; i<cars.length; i++) {
			System.out.printf("cars[%d] : ", i);
			cars[i].run();
		}
		
		System.out.println("=====================");
		for(Car c : cars)
			c.run();
	}
}
