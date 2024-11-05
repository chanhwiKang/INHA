package week11;

public class Cat extends Animal {
	public Cat() {
		this.kind = "포유류";
	}
	@Override
	public void sound() {
		System.out.println("냐옹");
	}
	public void catLife() {
		System.out.println("냥이 평균 수명은 약 12~15년 입니다.");
	}
	
}
