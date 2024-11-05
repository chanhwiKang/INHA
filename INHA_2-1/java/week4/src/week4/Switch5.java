package week4;

public class Switch5 {
	public static void main(String[] args) {
		String grade = "C";
		
		int score1 = 0;
		
		switch(grade) {
		case "A" -> score1 = 100;
		case "B" -> score1 = 90;
		case "C" -> score1 = 80;
		default -> score1 = 50;
		}
		System.out.println(score1);
		
		int score2 = switch(grade) {
			case "A" -> 100;
			case "B" -> {
				int result = 100 - 20;
				yield result;
			}
			case "C" -> 100 - 20;
			default -> 50;
		};
		System.out.println(score2);
			
		
	}
}
