package week4;

public class SwithEx {
	public static void main(String[] args) {
		char grade = 'B';
		
		// 이하 3가지 모두 같은 출력.
		switch(grade) {
		case 'A': case 'a':
			System.out.println("grade A");
			break;
		case 'B': case 'b':
			System.out.println("grade B");
			break;
		default:
			System.out.println("grade etc.");
		}
		
		switch(grade) {
		case 'A', 'a' -> {
			System.out.println("grade A");
		}
		case 'B', 'b' -> {
			System.out.println("grade B");
		}
		default -> {
			System.out.println("grade etc.");
		}
		}
		
		switch(grade) {
		case 'A', 'a' -> System.out.println("grade A");
		case 'B', 'b' -> System.out.println("grade B");
		default -> System.out.println("grade etc.");
		}
	}
}
