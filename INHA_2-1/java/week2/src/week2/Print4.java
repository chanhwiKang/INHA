package week2;

public class Print4 {
	public static void main(String[] args) {
		// 숫자 출력 포맷 %d : decimal
		// 실수 출력 포맷 %f : float
		
		System.out.printf("%d\n", (23 + 18));
		System.out.printf("숫자 연산 : 23 + 18 = %d\n", 23 + 18);

		System.out.printf("사칙연산(53, 17)\n");
		System.out.printf("더하기 : 53 + 17 = %d\n", 53 + 17);
		System.out.printf("빼기 : 53 - 17 = %d\n", 53 - 17);
		System.out.printf("곱하기 : 53 * 17 = %d\n", 53 * 17);
		System.out.printf("나누기 : 53 / 17 = %d\n", 53 / 17);
		
	}
}
