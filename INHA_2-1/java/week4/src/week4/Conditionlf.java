package week4;

import java.util.Scanner;

public class Conditionlf {
	public static void main(String[] args) {
		System.out.println("당신이 태어난 연도를 입력하세요.");
		Scanner sc = new Scanner(System.in);
		// int year = Integer.parseInt(sc.next());
		int age = 2024 - sc.nextInt() + 1;
		
		if (age <= 26 && age >=20) System.out.println("대학생");
		else if (age >= 17) System.out.println("고등학생");
		else if (age >= 14) System.out.println("중학생");
		else if (age >= 8) System.out.println("초등학생"); 
		else System.out.println("학생이 아닙니다.");
		
		sc.close();
	}
}
