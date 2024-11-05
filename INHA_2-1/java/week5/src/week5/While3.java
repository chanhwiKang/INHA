package week5;

import java.util.Scanner;

public class While3 {
	public static void main(String[] args) {
		int speed=0;
		boolean sw=true;
		Scanner sc = new Scanner(System.in);
		while(sw) {			
			System.out.println("-----------------");
			System.out.println("1.가속 2.감속 3.종료");
			System.out.println("-----------------");
			System.out.println("선택 -> ");
			int menu = sc.nextInt();
			if(menu == 1)
				speed++;
			else if(menu == 2) 
				speed--;
			else if (menu ==3) 
				sw=false;
			else System.out.println("다시");
			System.out.println("speed is " + speed);
		}System.out.println("prigram end");
		sc.close();
		
	}
}
