package week11;

public class ChildEx {
	public static void main(String[] args) {
		// *자동 타입 변환과 강제 타입 변환*
		
		Child child = new Child();
		child.method1(); // Parent Class에서 상속받은 method 
		child.method2(); // Child Class에서 재정의한 method 
		child.method3(); // Child Class에서 선언한 method
		System.out.println("========================");
		
		// 자동 타입 변환. 부모_클래스 변수 = 자식_클래스_객체를 대입함으로써 가능
		Parent parent = child; // Child -> Parent
				
		parent.method1();
		parent.method2(); // 자동 타입 변환이 됐을 때, 부모 클래스 변수라도 자식 클래스의 재정의된 method출력
//		parent.method3(); 부모 클래스 변수는 자식 객체에만 있는 필드나 클래스에 호출 불가.
		
		parent.field1 = "aaaa";
//		parent.field2 = "bbbb"; 부모 class field는 자식 class field에 접근 불가.
		
		// 강제 타입 변환. 자식_클래스_변수 = (자식_클래스_이름)부모_클래스_객체. 대입하는 경우
		// 자동 타입 변환이 된 경우에만 가능.
			// parent -> 자동 타입 변환이 된 경우
		child = (Child)parent; 
		child.field2 = "bbbb";
		child.method3();
		
			// 자동 타입 변환이 되지 않은 parent인 경우
		Parent parent2 = new Parent(); // 순수 parent 객체
		Child child2 = (Child) parent2; // err. Parent cannot be cast to class week11.Child.
		child2.field1 = "aaaa";
		child2.field2 = "bbbb";
		child2.method1();
		child2.method2();
		child2.method3();
	}
}












