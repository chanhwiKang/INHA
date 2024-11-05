package week13;

public class ConsumerThread extends Thread {
	private DataBox dataBox;
	
	public ConsumerThread(DataBox dataBox) {
		this.dataBox = dataBox;
	}
	
	@Override
	public void run() {
		for (int i=1; i<=3; i++) {
			try {
				String data = dataBox.getData();
			} catch (InterruptedException e) {	}
			
		}
	}
}
