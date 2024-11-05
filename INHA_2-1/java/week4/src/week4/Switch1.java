package week4;

public class Switch1 {
	public static void main(String[] args) {
		char grade = 'A';
		int rand = (int) (Math.random()*4+8);
		System.out.println(rand);
		switch(grade) {
		case 'A':
			System.out.println("A grade");
			break;
		case 'B':
			System.out.println("B grade");
			break;
		default:
			System.out.println("etc. grade");
			
		}
	}
}
