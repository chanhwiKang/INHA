package week2;

public class DataType3 {
	public static void main(String[] args) {
		char cData1 = 'A';		// 문자 저
		char cData2 = 65;		// 10진수 
		char cData3 = '\u0041';	// 16진수 
		System.out.println("cData1 = " + cData1);
		System.out.println("cData2 = " + cData2);
		System.out.println("cData3 = " + cData3);
		
		char cData4 = '가';		
		char cData5 = 44032;	 
		char cData6 = '\uac00';	 
		System.out.println("cData4 = " + cData4);
		System.out.println("cData5 = " + cData5);
		System.out.println("cData6 = " + cData6);
		
		/*
		 * char 타입 변수의
		 * 유니코드 값을 알고싶으면
		 * int 타입의 변수에 저장해서 확
		 */
		int cData7 = 'B';		
		int cData8 = '하';	 
		int cData9 = '&';	 
		System.out.println("cData7 = " + cData7);
		System.out.println("cData8 = " + cData8);
		System.out.println("cData9 = " + cData9);
		
		int cData10 = cData7 + cData9;
		System.out.println("cData7 + cData9 = " + cData10);
		
		char cData11 = (char) cData10; // (char)(cData7 + cData9)
		System.out.println("cData7 + cData9의 char =  " + cData11);
		
	}
}
