package week3;

public class ShiftOperator {
	public static void main(String[] args) {
		// <<는 2의 n승의 값을 얻을 수 있다.
		System.out.println("1 << 3 = " + (1 << 3));
		// >>는 <<랑 반대.
		System.out.println("-8 >> 3 = " + (-8 >> 3));

		System.out.println("-9 >>> 3 = " + (-8 >>> 3));
	}
}
