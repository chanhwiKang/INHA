package week13;

public class DataBox {
	private String data;
	
	// 생산자가 스레드가 실행하는 메소드
	public synchronized void setData(String data) throws InterruptedException {
		if (this.data != null) {
			// data가 있으면 -> write X
			wait();
		}
		this.data = data;
		System.out.println("Producer Thread가 생성한 data: " + this.data);
	
		// wait()된 스레드(소비자 스레드)를 깨워서 실행 대기로 만들기 
		notify();
	}
	
	public synchronized String getData() throws InterruptedException {
		if (this.data == null) {
			// data가 없으면 -> read X
			wait();
		}
		String returnValue = this.data;
		System.out.println("Consumer Thread가 읽은 data : " + returnValue);
		
		// data를 읽은 뒤 생산자가 write할 수 있도록 data 공간 비우기
		this.data = null;
		notify();
		return returnValue;
	}
}
