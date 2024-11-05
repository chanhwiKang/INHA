package week2;

public class Print3 {
	public static void main(String[] args) {
		System.out.println(17+35);
		
		// 자바에서 문자열 뒤에 + 가 오면 나머지 데이터도 문자로 바뀐다.
		System.out.println("17 + 35 = " + 17+35);
		
		// 문자열과 연산식의 결과를 출력하기 위해 괄호를 사용한다.
		System.out.println("17 + 35 = " + (17 + 35));
		
		// 문자열의 출력 포맷(printf)
		// %기호를 사용
		// s : 문자열 출력 포맷
		System.out.printf("이름 : %s \n", "java");
		System.out.printf("이름 : %s, %s \n", "java", "eclips", "aaa"); // err 안남
//		System.out.printf("이름 : %s, %s, %s \n", "java", "eclips"); // err
		
	}
}
