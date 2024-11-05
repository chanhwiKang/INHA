package week3;

public class PromotionType {
	public static void main(String[] args) {
		byte bValue = 25;
		int iValue = bValue; //자동 타입 변환
		System.out.println(iValue);
		
		char cValue = '가';
		iValue = cValue;
		System.out.println(iValue); // unicode value print
		
		iValue = 375;
		long lValue = iValue;
		System.out.println(lValue); 
		
		double dValue = iValue;
		System.out.println(dValue); 
		
	}
}
