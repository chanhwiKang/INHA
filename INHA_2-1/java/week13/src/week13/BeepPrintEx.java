package week13;

public class BeepPrintEx {
	public static void main(String[] args) throws InterruptedException {
		for(int i=0; i<5; i++) {
			System.out.println("Beep");
			Thread.sleep(1000);	//sleep() 실행 중지
		}
		
		for(int i=0; i<5; i++) {
			System.out.println("****");
			Thread.sleep(1000);
		}
	}
}
