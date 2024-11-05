package week3;

public class BitOperator {
	public static void main(String[] args) {
		byte n1 = 45;
		byte n2 = 25;
		int result = n1 & n2; // 비트 연산시 결과값은 int
		
		System.out.println("n1 = " + n1);
		System.out.println("n2 = " + n2);
		System.out.println("result = " + result);
		System.out.println("-----------------");
		System.out.printf("n1        = %6s\n", Integer.toBinaryString(n1));
		System.out.printf("n2        = %6s\n", Integer.toBinaryString(n2));
		System.out.printf("result(&) = %6s\n", Integer.toBinaryString(result));
		
		result = n1 | n2;
		System.out.printf("result(|) = %6s\n", Integer.toBinaryString(result));
		
		result = n1 ^ n2;
		System.out.printf("result(^) = %6s\n", Integer.toBinaryString(result));
		
	}
}
