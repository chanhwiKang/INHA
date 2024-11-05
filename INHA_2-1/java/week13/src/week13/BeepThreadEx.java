package week13;

public class BeepThreadEx {
	public static void main(String[] args) throws InterruptedException {
		// 부모클래스 변수 = 자식클래스 객체 대입 가능
		Thread thread = new BeepThread();
		thread.start();
		
		for(int i=0; i<5; i++) {
			System.out.println("****");
			Thread.sleep(1000);
		}
	}
}
