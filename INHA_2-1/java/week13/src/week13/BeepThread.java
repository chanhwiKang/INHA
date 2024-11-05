package week13;

public class BeepThread extends Thread{
	// Thread를 상속받아서 run() method를 재정의해서 사용
	@Override
	public void run() {
		for(int i=0; i<5; i++) {
			System.out.println("Beep");
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
			}
		}
	}
}
