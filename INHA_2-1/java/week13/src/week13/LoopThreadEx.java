package week13;

public class LoopThreadEx {
	public static void main(String[] args) {
		for(int i=1; i<=10; i++) {
			Thread thread = new LoopThread("thread_"+i);
			if(i != 10) 
				thread.setPriority(Thread.MIN_PRIORITY);
			else
				thread.setPriority(Thread.MAX_PRIORITY);
			thread.start();
		}
	}
}
