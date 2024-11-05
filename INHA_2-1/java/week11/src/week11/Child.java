package week11;

public class Child extends Parent {
	public String field2;
	
	// Parent 클래스의 method2를 재정의
	@Override
	public void method2() {
		System.out.println("Child-method2()");
	}
	
	// 필요한 경우 필드나 메소드 추가 가능
	public void method3() { // Child Class에만 있는 메소드
		System.out.println("Child-method3()");		
	}
}
