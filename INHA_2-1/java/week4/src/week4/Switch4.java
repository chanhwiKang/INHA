package week4;

public class Switch4 {
	public static void main(String[] args) {
		String phone = "iPhone";
		
		switch(phone) {
		case "iPhone" -> System.out.println("apple");
		case "galaxy" -> System.out.println("samsung");
		default -> System.out.println("etc.");
		
		}
	}
}
