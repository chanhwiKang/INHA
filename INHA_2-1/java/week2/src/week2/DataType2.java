package week2;

public class DataType2 {
	public static void main(String[] args) {
		float fValue = 3.14f;
		double dValue = 3.14;
		System.out.println("fValue = " + fValue);
		System.out.println("dValue = " + dValue);
		
		// 정밀도 테스트
		fValue = 0.1234567890123456789f;
		dValue = 0.1234567890123456789;
		System.out.println("fValue = " + fValue);
		System.out.println("dValue = " + dValue);

		// e 사용하기
		int iData = 4500000;
		float fData = 3e7f; // 10의 7
		double dData1 = 3e7;
		double dData2 = 3e-7;

		System.out.printf("iData = %d\n", iData);
		System.out.printf("fData = %.4f\n", fData);		
		System.out.printf("dData1 = %.2f\n", dData1);
		System.out.printf("dData2 = %10.8f\n", dData2);
		
	}
}