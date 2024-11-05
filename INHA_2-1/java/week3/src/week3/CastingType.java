package week3;

public class CastingType {
	public static void main(String[] args) {
		int iData = 65;
		char cData = (char)iData; // casting
		System.out.println(cData);
		
		long lData = 500; // 자동 타입 변환 (뒤에 L을 안써도 됨)
		iData = (int)lData;
		System.out.println(iData);
		
		double dData = 3.14;
		iData = (int)dData; // 실수를 정수에 대입하여 소수점 이하 탈락
		System.out.println(iData);
		
		System.out.println("================");
		int iValue = 128; // overflow
		byte bValue = (byte)iValue;
		System.out.println(bValue);
		
		// 데이터 범위 체크
		if (iValue >= Byte.MIN_VALUE && iValue <= Byte.MAX_VALUE) {
			bValue = (byte) iValue;
			System.out.println(bValue);
		} else {
			System.out.println("casting하고자하는 변수의 값을 확인하세요.");
		}
	}
}
