package week13;

public class ThreadA extends Thread {
	public ThreadA() {
		setName("ThreadA");
	}

	// Thread를 상속받으면 Run() 재정의필요
	@Override
	public void run() {
		for (int i=0; i<5; i++) {
			System.out.println(getName() + "작동 중");
		}
	}
}
