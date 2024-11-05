package package1;

public class ClassC {
	// 필드의 접근제한자
	public int field1;
	int field2;
	private int field3;

	public ClassC() {
		field1 = 1;
		field2 = 1;
		field3 = 1;
		Method1();
		Method2();
		Method3();
	}
	
	// Mathod의 접근제한자
	public void Method1() {}
	void Method2() {}
	private void Method3() {}
}
