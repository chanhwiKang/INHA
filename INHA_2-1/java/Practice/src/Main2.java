import java.util.Scanner;

public class Main2 {
	public static void main(String[] args) {
		System.out.println("PLAY MUSIN ON SMART PHONE");
		Scanner sc = new Scanner(System.in);
		int menu;
		
		SmartPhone sp = new SmartPhone();
		EarPhone ep = null;
		
		while (true) {
			System.out.println("\nChoose EarPhone Type. 1. Buds / 2. AirPods / 3. TonFree");
			
			menu = sc.nextInt();
			if (menu == 4) {
				break;
			}
			switch(menu) {
			case 1:
				ep = new Buds(); break;
			case 2:
				ep = new Airpods(); break;
			case 3:
				ep = new TonFree(); break;
			}
			sp.musicOn(ep);
			sp.musicOff(ep);
		}
		System.out.println("Program off");
		sc.close();
	}
}
