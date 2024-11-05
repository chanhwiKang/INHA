package week4;

public class Switch2 {
	public static void main(String[] args) {
		int time = (int) (Math.random() * 4 + 8);
		
		switch(time) {
		case 8:
			System.out.println("8am");
			break;
		case 9:
			System.out.println("9am");
			break;
		case 10:
			System.out.println("10am");
			break;
		case 11:
			System.out.println("11am");
			break;
		default:
			System.out.println(time);
		}
	}
}
