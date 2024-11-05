package week4;

import java.util.Scanner;

public class BodyBMI {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.println("이름");
		String name = sc.next();
		
		System.out.println("키(cm)");
		
		double height = sc.nextDouble()/100;
		
		System.out.println("체중");
		int weight = sc.nextInt();
		
		double bmi = weight / (height * height);
		
		String result = "";
		if (bmi >= 30) result = "고도비만";
		else if (bmi >= 25) result = "비만";
		else if (bmi >= 23) result = "과체중";
		else if (bmi >= 18) result = "정상";
		else result = "해골";
		System.out.printf("%s %.1f %s",name, bmi, result);
		
	}
}
