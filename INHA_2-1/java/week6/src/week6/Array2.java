package week6;

public class Array2 {

	public static void main(String[] args) {
		// 값 목록으로 배열을 생성하는 방법
		int[] score = {70, 80, 65, 82, 50};
		String[] names = {"java", "c", "python", "c3"};
		double[] dArray1;
		dArray1 = new double[] {0.1, 0.2, 0.3, 0.4};
		
		// new 연산자로 배열을 생성하면, 자동으로 기본값으로 초기화된다.
		int[] intArray = new int[5];
		for (int i=0; i<intArray.length; i++) 
			System.out.printf("intArray[%d]=%d\n", i, intArray[i]);
		
		double[] dArray2 = new double[5];
		for (int i=0; i<dArray2.length; i++) 
			System.out.printf("dArray[%d]=%f\n", i, dArray2[i]);
		
		String[] sArray= new String[4];
		for (int i=0; i<sArray.length; i++) 
			System.out.printf("sArray[%d]=%s\n", i, sArray[i]);
		
		// 배열에 새로운 값을 저장하려면 대입 연산자를 사용
		// names[] 배열을 sArray[] 배열에 저장
		
		for (int i=0; i<sArray.length; i++) {
			sArray[i] = names[i];
			System.out.printf("sArray[%d]=%s\n", i, sArray[i]);
		}
	}
}
