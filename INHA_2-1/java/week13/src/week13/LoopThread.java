package week13;

public class LoopThread extends Thread{
	public LoopThread(String name) {
		setName(name);
	}
	
	@Override
	public void run() {
		System.out.println(getName());
	}
}
