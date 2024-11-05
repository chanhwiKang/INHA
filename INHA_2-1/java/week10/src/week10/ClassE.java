package week10;

import package1.ClassC;

public class ClassE {
	public ClassE() {
		ClassC aa = new ClassC();
		aa.field1 = 1;
//		aa.field2 = 1;	default라 안됨
		aa.Method1();
//		aa.Method2();	default라 안됨
	}
	
	
}
