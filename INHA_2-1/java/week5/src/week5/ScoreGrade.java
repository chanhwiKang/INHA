package week5;
import java.util.*;
public class ScoreGrade {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String grade;
		System.out.println("  Score      Grade  ");
		System.out.println("====================");
		
		while(true) {
			int score = sc.nextInt();
			if (score >= 90) grade="A";
			else if(score >= 80) grade = "B";
			else if(score >= 70) grade = "C";
			else if(score >= 60) grade = "D";
			else if(score >= 0) grade = "F";
			else break;
			System.out.printf("    %d          %s  \n", score, grade);
		}
		System.out.println("program end.");
		sc.close();
	}
}
