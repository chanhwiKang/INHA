package week9;

import java.util.Scanner;

public class Car2Ex {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		Car2 myCar = new Car2();
		
		int gasVal = 0;
		boolean gasState = myCar.isLeftGas();
		
		myCar.setGas(5);
		
		while(true) {
			if(gasState) {
				System.out.println("출발.");
				myCar.run();
			}
			System.out.print("gas를 넣으세요 >> ");
			gasVal = sc.nextInt();
			if(gasVal == 0)break;
			myCar.setGas(gasVal);
			gasState = myCar.isLeftGas();
		}
		
//		if (myCar.isLeftGas()) {
//			System.out.println("출발.");
//		}
//		myCar.run();
		sc.close();
		System.out.println("Program End");
	}
}
