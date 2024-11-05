package week13;

public class BeepTaskEx {
	public static void main(String[] args) throws InterruptedException {
		// interface 변수 = interface 구현 객체 대입 가능 
		Runnable beepTask = new BeepTask();
		
		// 스레드 객체 생성
		Thread thread = new Thread(beepTask);
		
		// 스레드 실행
		thread.start();
		
		// 메인 스레드가 실행할 명령문 기술
		for(int i=0; i<5; i++) {
			System.out.println("****");
			Thread.sleep(1000);
		}
	}
}
