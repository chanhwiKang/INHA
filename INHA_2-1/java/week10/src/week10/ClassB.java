package week10;

public class ClassB {
	// 동일한 패키지인 경우
	ClassA c1 = new ClassA(true);	// public
	ClassA c2 = new ClassA(10);		// default
//	ClassA c3 = new ClassA("문자열"); // => private라 불가능
}
