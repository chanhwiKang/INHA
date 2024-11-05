package week5;
import java.util.Scanner;

public class UpAndDown {
	public static void main(String[] args) {
		int randNum = (int)(Math.random()*100+1);
		Scanner sc = new Scanner(System.in);
		while(true) {
			System.out.print("숫자를 맞혀 보세요(1~100) >> ");
			int playerNum = sc.nextInt();
			if (playerNum <= 0 || playerNum > 100) continue;
			else {
				if (randNum > playerNum)
					System.out.println("숫자가 너무 작습니다.");
				else if (randNum < playerNum)
					System.out.println("숫자가 너무 큽니다.");
				else {
					System.out.println("정답입니다. 랜덤 숫자는 "+randNum+"입니다.");
					break;
				}
			}
		}
	}
}
