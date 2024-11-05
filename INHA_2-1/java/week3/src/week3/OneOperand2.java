package week3;

public class OneOperand2 {
	public static void main(String[] args) {
		int var1 = 10;
		int var2 = ~var1; // 틸드, 1의 보수
		int var3 = ~var1 + 1; // 2의 보수
		System.out.println("var1 = " + var1);
		System.out.println("var2 = " + var2);
		System.out.println("var3 = " + var3);
		
		System.out.printf("십진수(%d) = %32s\n", var1, Integer.toBinaryString(var1));
		System.out.printf("십진수(%d)= %32s\n", var2, Integer.toBinaryString(var2));
		System.out.printf("십진수(%d)= %32s\n", var3, Integer.toBinaryString(var3));
		
	}
}
