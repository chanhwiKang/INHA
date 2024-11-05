package week3;

public class ConditionOperator {
	public static void main(String[] args) {
		int n1 = 35;
		int n2 = 47;
		String result;
		
		result = (n1 > n2)? "n1 is big":"n2 is big";
		System.out.println(result);
		
		System.out.printf("%d가 %d보다 더 큽니까? %b\n", n1, n2, (n1>n2));
		
		boolean bReasult;
		bReasult = (n1 > n2)? true:false;
		System.out.println(bReasult);
		
		System.out.println("----------------");
		
		int score = 90;
		String r1;
		r1 = (score>90)? "우수" : ((score > 80)? "보통" : "미달");
		System.out.println(r1);
	}
}
