package week13;

public class BeepTaskEx2 {
	public static void main(String[] args) throws InterruptedException {
		// 익명 객체(인터페이스)를 바로 대입해서 스레드 생성
		Thread thread = new Thread(new Runnable() {
			
			@Override
			public void run() {
				// Thread가 실행할 명령문을 기술
				for(int i=0; i<5; i++) {
					System.out.println("Beep");
					try {
						Thread.sleep(1000);
					} catch (InterruptedException e) {
					}
				}
			}
		});
		// thread 실행
		thread.start();
		for(int i=0; i<5; i++) {
			System.out.println("****");
			Thread.sleep(1000);
		}
		
	}
}
