package week14;

public class MyClassEx<T> {
	public static void main(String[] args) {
		MyClass<Integer> intClass = new MyClass<Integer>();
		intClass.printValue(100);
		
		MyClass<String> strClass = new MyClass<String>();
		strClass.printValue("홍길동");
		
		MyClass<Boolean> boolClass = new MyClass<Boolean>();
		boolClass.printValue(true);
	}
}
