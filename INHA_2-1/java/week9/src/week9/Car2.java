package week9;

public class Car2 {
	int gas;
	
	void setGas(int gas) {
		this.gas += gas;
	}
	boolean isLeftGas() {
		boolean result;
		if (gas > 0) {
			System.out.println("Gas가 있습니다.");
			result = true;
		}else {
			System.out.println("Gas가 없습니다.");
			result = false;
		}
		return result;
	}
	void run() {
		while(true) {
			if (gas > 0) {
				System.out.println("달립니다. (가스 잔량: " + gas +")");
				gas--;
			}else {
				System.out.println("멈춥니다. (가스 잔량: " + gas +" )");
				return;
			}
		}
	}

}
