package week5;
import java.util.*;
public class DoWhile1 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("메시지를 입력하세요.");
		System.out.println("종료하려면 q.");
		String str;
		
		do {
			System.out.println(">");
			str = sc.nextLine();
			System.out.println(str);
		}while(!str.equals("q"));
		System.out.println("program end");
		sc.close();
	}
}
