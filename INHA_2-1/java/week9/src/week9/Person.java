package week9;

public class Person {
	// 키를 feet 단위로 받아서 cm로 변환할 때 필요한 데이터를 상수로 저장.
	// static final = 상수.
	static final double FEET_CONSTANT = 30.48;
	
	// final = 값을 첫 초기화 한 값으로 고정됨. 변경 불가.
	final String nation = "Korea";
	final String ssn;
	
	String name;
	double height;
	
	public Person(String ssn, String name, double height) {
		this.ssn = ssn;
		this.name = name;
		this.height = height;
	}
	
}
