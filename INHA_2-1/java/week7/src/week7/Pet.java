package week7;

public class Pet {
	String type;
	int age;
	int leg;
	Pet(String type, int age) {
		this.type = type;
		this.age = age;
		this.leg = 4;
	}
	public void printPet() {
		System.out.println(type+"은(는) "+age+"개월입니다.");
	}
	public void printLeg() {
		System.out.println(type+"은(는) "+leg+"입니다.");
	}
}
