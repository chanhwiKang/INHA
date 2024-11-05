package week3;

public class OneOperand1 {
	public static void main(String[] args) {
		short sValue = 100;
		// short sReasult = -sValue;
		int sResult = -sValue;
		System.out.println(sResult);
		
		byte bValue = -100;
		// byte bReasult = -bValue;
		int bResult = -bValue;
		System.out.println(bResult);
		
		System.out.println("------------------");
		// 증감 연산자(++, --)
		int x = 10;
		int y = 10;
		int z;
		
		System.out.println("x++ = " + x++); // 출력 후 증가. 출력 : 10
		System.out.println("x = " + x); // 출력 : 11
		System.out.println("------------------");
		
		System.out.println("++x = " + ++x); // 증가 후 출력. 출력 : 12
		System.out.println("x = " + x); // 출력 : 12
		System.out.println("------------------");
		
		z = x++; // z에 12가 복사가 되고 x는 13이 됨.
		System.out.println("z = " + z + ", x = " + x);
		System.out.println("------------------");
		
		z = ++x + y--; //24?
		System.out.println("z = " + z);
		System.out.println("x = " + x);
		System.out.println("y = " + y);
		System.out.println("------------------");
		
	}
}
