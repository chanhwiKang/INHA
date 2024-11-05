package week13;

public class BeepTask implements Runnable {
	// 인터페이스를 구현하는 구현 클래스
	
	@Override
	public void run() {
		// 스레드가 실행할 명령문을 기술
		for (int i=0; i<5; i++) {
			System.out.println("Beep");
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
			}
		}
	}
	
}
