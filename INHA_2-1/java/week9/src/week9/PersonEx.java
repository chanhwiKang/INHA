package week9;

public class PersonEx {
	public static void main(String[] args) {
		Person p = new Person("980324", "강찬휘", 6.1);
		System.out.println(p.nation);
		System.out.println(p.ssn);
		System.out.println(p.name);
		System.out.println(p.height*Person.FEET_CONSTANT+"cm");
	
		// final로 선언되어 변경 불가.
		// p.nation = "America";
	}
}
