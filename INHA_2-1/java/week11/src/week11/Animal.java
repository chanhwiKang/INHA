package week11;

public abstract class Animal {
	// 추상 클래스는 객체 생성이 안됨(new 연산자 불가), 상속만 가능하다.
	public String kind;
	
	public void breathe() {
		System.out.println("숨을 쉽니다.");
	}
	
	// 각 동물의 울음소리가 다르다. 추상 메소드로 정의 -> 자식 클래스에서 반드시 재정의 필요
	public abstract void sound();
}
