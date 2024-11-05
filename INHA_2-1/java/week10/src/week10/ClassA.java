package week10;

public class ClassA {
	ClassA c1 = new ClassA(true);
	ClassA c2 = new ClassA(10);
	ClassA c3 = new ClassA("문자열");
	
	// 생성자의 접근 제한자
	
	// 생성자 오버로
	public ClassA(boolean data) {
		// public 누구나 어디서든 사용 가능
		
	}
	
	ClassA(int data) {
		// 접근 제한자 생략 시 default => 같은 패키지 안에서만 사용가능
		
	}
	
	private ClassA(String data) {
		// private 자기 클래스 안에서만 사용가능
		
	}
}
