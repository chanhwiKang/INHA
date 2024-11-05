package week3;
import java.util.Scanner;

public class Prac_conditionb {
	public static void main(String[] args) {
		System.out.println("Score -> ");
		Scanner sc = new Scanner(System.in);
		int score = sc.nextInt();
		char grade = score>90? 'A':score>80? 'B':'C';
		System.out.println(grade);
	}
}
