package week6;
import java.util.*;
public class Reference2 {
	public static void main(String[] args) {
		// 메세지를 입력받아 출력하는 프로그램
		// 끝이 입력되면 프로그램 종료
		Scanner sc = new Scanner(System.in);
		String str;
		
		System.out.println("메세지를 입력하세요");
		while(true) {
			System.out.println(">> ");
			str = sc.nextLine();
			
			System.out.println(str);
			if (str.equals("end")) break;
		}
		System.out.println("program end");
		sc.close();
	}
}
