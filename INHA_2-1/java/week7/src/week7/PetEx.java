package week7;

public class PetEx {
	public static void main(String[] args) {
		Pet pet1 = new Pet("dog", 13);
		Pet pet2 = new Pet("cat", 14);
		Pet pet3 = new Pet("bird", 3);
		
		pet1.printPet();
		pet2.printPet();
		pet3.printPet();
		
		System.out.println();
		pet3.leg = 2;
		pet1.printLeg();
		pet2.printLeg();
		pet3.printLeg();
	}
}
