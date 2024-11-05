package week13;

public class CalUser1 extends Thread{
	// 공유 객체 선언
	private Calculator calculator;
	
	public void setCalculator(Calculator calc) {
		this.calculator = calc;
		setName("User1");
	}
	
	@Override
	public void run() {
		try {
			calculator.setMemory(100);
		} catch (InterruptedException e) {	}
	}
}
