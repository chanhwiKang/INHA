package week9;

public class CalcEx {
	public static void main(String[] args) {
		Calculator c1 = new Calculator("White", "10");
		System.out.println(c1.color + ", "+ c1.size);
		c1.powerOn();
		
		System.out.println(c1.plus(10, 20));
		System.out.println(c1.divide(10, 20));
		
		byte b1 = 10;
		byte b2 = 20;
		// 매개변수의 자동 타입변환도 가능.
		System.out.println("byte:divide(10, 20) = " + c1.divide(b1, b2));
		System.out.println("================");
		c1.exac();
		
		System.out.println("================");
		
		int[] intArray = {1, 2, 3, 4, 5};
		System.out.println("Array의 값: " + c1.sum1(intArray));
		
		int s1 = c1.sum1(new int[] {1, 2, 3, 4, 5});
		System.out.println("Array의 값: " + s1);
		 	
		s1 = c1.sum2(1, 2, 3, 4, 5);
		System.out.println("Array의 값: " + s1);
		
		System.out.println("=====정적멤버=====");
		int radius = 8;
		System.out.println(Calculator.pi * radius * radius);
		System.out.println(Calculator.minus(15, 7));
		
		
		
		
		c1.powerOff();
	}
}
