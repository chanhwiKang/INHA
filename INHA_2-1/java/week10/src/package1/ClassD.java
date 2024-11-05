package package1;

public class ClassD {
	public ClassD() {
		ClassC aa = new ClassC();
		aa.field1 = 1;
		aa.field2 = 1;
//		aa.field3 = 1;	private라 안됨
		aa.Method1();
		aa.Method2();
//		aa.Method3();	private라 안됨
	}
}
