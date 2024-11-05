package week5;
import java.util.Scanner;
public class While2 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int num1, num2;
		while(true) {
			System.out.println("첫번째 수 입력");
			num1 = sc.nextInt();
			System.out.println("두번째 수 입력");
			num2 = sc.nextInt();
			
			System.out.printf("%d + %d = %d\n", num1, num2, num1+num2);
		}
	}
}
