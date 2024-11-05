package week6;

public class Reference1 {
	public static void main(String[] args) {
		// 기본 데이터 타입의 변수는 스택영역에 생성되면서, 값도 같이 저장
		int iVal1=100;
		int iVal2=100;
		System.out.println("iVal1 == iVal2: "+(iVal1==iVal2));
		
		// 참조 타입의 변수는 스택에 저장, 해당 객체의 값은 힙영역에 저장
		// stack에는 주소가 저장된다.
		String sVal1="java";
		String sVal2="java";
		// 자바는 문자열 리터럴이 동일하면, String 객체를 공유한다. => 동일한 주소
		System.out.println("sVal1 == sVal2: "+(sVal1==sVal2));
		System.out.println("sVal1 == sVal2: "+(sVal1==sVal2?"참조가 같다":"참조가 다르다"));
		
		// new 연산자를 이용하면, 힙 영역에 새로운 String 객체가 생성.
		String sVal3=new String("java");
		String sVal4=new String("java");
		System.out.println("sVal3 == sVal4: "+(sVal3==sVal4));
		System.out.println("sVal3 == sVal4: "+(sVal3==sVal4?"참조가 같다":"참조가 다르다"));
		
		// String 객체가 동일한 문자열을 갖고 있는지 비교할 때,
		// equals method를 이용한다.
		if (sVal3.equals(sVal4))
			System.out.println("동일한 문자열");
		else
			System.out.println("다른 문자열");
		
	}
}
