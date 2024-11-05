package week3;

public class TwoOperamd1 {
	public static void main(String[] args) {
		int x = 15;
		double y = 0.0;
		
		double z1 = x / y; // 분모가 0. 출력은 Infinity
		System.out.println("z1 = " + z1);
		
		double z2 = x % y; // 출력은 NaN(Not a Number)
		System.out.println("z2 = " + z2);
		
		System.out.println("-----------------");
		
		int code1 = 'A';
		if (code1 >= 65 && code1 <= 90) {
			System.out.println((char)code1 + "은(는) 알파벳 대문자이다.");
		}
		
		int code2 = 'b';
		if (!(code2 < 97) && !(code2 > 122)) {
			System.out.println((char)code2 + "은(는) 알파벳 소문자이다.");
		}
		
		int iValue = 4;
		if ((iValue % 2 == 0) || (iValue % 3 == 0)) {
			System.out.println(iValue + "은(는) 2 또는 3의 배수이다.");
		}
	}
}
