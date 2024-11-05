package week4;

public class IfDice {
	public static void main(String[] args) {
		// Math.random() -> 0.0 ~ 0.9999.. 실수 값을 리턴
		double num = Math.random();
		System.out.println(num);
		System.out.println((int) (num*6+1));
	}
}
