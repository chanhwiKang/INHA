package week11;

public class AnimalEx {
	public static void main(String[] args) {
		Dog dog = new Dog();
		Cat cat = new Cat();
		dog.sound();
		cat.sound();
		System.out.println("============");
		
		// 자동타입변환. 부모_클래스 변수 = 자식_클래스_객체 
		Animal animal = new Dog();
		animal.sound();
		animal = new Cat();
		animal.sound();
		System.out.println("============");
		
		// 매개변수의 다형성 적용
		AnimalEx.animalSound(new Dog());
		AnimalEx.animalSound(new Cat());
//		AnimalEx.animalSound(new Animal()); 추상 클래스이기 때문에 new 연산자 사용 불가
	}
	
	private static void animalSound(Animal animal) {
		animal.sound();
		animal.breathe();
		
//		animal.dogLife(); Dog 클래스에만 있는 클래스
//		animal.carLife(); Cat 클래스에만 있는 클래스

		if (animal instanceof Dog) { // animal이 Dog객체로 자동타입변환이 된건지?
			System.out.println("Dog 객체로 변환 가능");
			Dog dog = (Dog)animal;
			dog.dogLife();
		} else if (animal instanceof Cat){
			System.out.println("Cat 객체로 변환 가능");
			Cat cat = (Cat)animal;
			cat.catLife();
		}
	}
}
