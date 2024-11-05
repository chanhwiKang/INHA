package week4;

import java.util.Scanner;

public class Switch6 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("점수 입력(0 ~ 100) : ");
		int score = sc.nextInt();
		char grade = switch(score/10) {
		case 10, 9 -> 'A';
		case 8 -> 'B';
		case 7 -> 'C';
		default -> 'D';
		};
		System.out.println(grade);
		sc.close();
	}
}
