package week10;

public class SmartPhoneEx {
	public static void main(String[] args) {
		SmartPhone mine = new SmartPhone("galaxy", "white");
		System.out.println(mine.model);
		System.out.println(mine.isWifi());
		
		mine.bell();
		mine.sendVoice("Hello");
		mine.receiveVoice("asd");
		mine.hangUp();
		mine.setWifi(true);
		mine.internet();
	}
}
