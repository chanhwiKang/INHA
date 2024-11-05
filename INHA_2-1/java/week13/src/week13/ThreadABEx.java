package week13;

public class ThreadABEx {
	public static void main(String[] args) {
		Thread mainThread = Thread.currentThread();
		System.out.println("프로그램 시작 스레드 이름: " + mainThread);
		
		// 스레드 객체 생성
		ThreadA threadA = new ThreadA();
		ThreadB threadB = new ThreadB();
		// 스레드 실행
		threadA.start();
		System.out.println("작업 스레드 이름 : " +threadA.getName());
		threadB.start();
		System.out.println("작업 스레드 이름 : " +threadB.getName());
	}
}
