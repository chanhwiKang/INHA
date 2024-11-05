package week13;

public class CalUser2 extends Thread{
	// 공유 객체 선언
	private Calculator calculator;
	
	public void setCalculator(Calculator calc) {
		this.calculator = calc;
		setName("User2");
	}
	
	@Override
	public void run() {
		try {
			calculator.setMemory(50);
		} catch (InterruptedException e) {	}
	}
}
