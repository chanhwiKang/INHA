package week13;

public class ProducerThread extends Thread {
	// 생산자 클래스
	private DataBox dataBox;
	
	public ProducerThread(DataBox dataBox) {
		this.dataBox = dataBox;
	}
	
	@Override
	public void run() {
		for (int i=1; i<=3; i++) {
			String data = "Data-" + i;
			try {
				dataBox.setData(data);
			} catch (InterruptedException e) {	}
		}
	}
}
