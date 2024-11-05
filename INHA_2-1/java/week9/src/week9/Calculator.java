package week9;

public class Calculator {
	// 인스턴스 멤버 => 반드시 객체를 생성해야 접근 가능
	String color;
	String size;
	
	// 정적 멤버 => static으로 선언됨. 객체 생성없이도 접근이 가능.
	static double pi = 3.14;
	static int minus(int x, int y) {
		return x-y;
	}
	
	public Calculator(String color, String size) {
		this.color = color;
		this.size = size;
	}
	

	void powerOn() {
		System.out.println("전원을 켭니다.");
	}
	void powerOff() {
		System.out.println("전원을 끕니다.");
	}
	int plus(int num1, int num2) {
		return num1 + num2;
	}
	double divide(int num1, int num2) {
		return (double)num1 / num2;
	}
	double avg(int x, int y) {
		return divide(plus(x, y), 2);
	}
	void printFuction(String strMsg) {
		System.out.println(strMsg);
	}
	void exac() {
		double result = avg(7, 10);
		printFuction("실행 결과: " + result);
	}
	// 동일한 데이터타입으로 넘어오는 경우 배열을 이용한다.
	int sum1(int[] values) {
		int result=0;
		for(int i=0; i<values.length; i++) {
			result += values[i];
		}
		return result;
	}
	// 매개변수의 개수를 알 수 없을때, 데이터 타입은 같아야함.
	// 배열로 만들어짐.
	int sum2(int ...values) {
		int sum = 0;
		for(int i : values) {
			sum += i;
		}
		return sum;
	}

}
