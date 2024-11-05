package week10;

public class SonicAirplane extends Airplane {
	public static final int NORMAL = 1;
	public static final int SUPERSONIC = 2;
	
	int flymode = NORMAL;
	
	private int soundSpeed;
	private int maxSpeed;
	
	// fly mothod override(재정의)
	@Override
	public void fly() {
		if(flymode == SUPERSONIC) {
			System.out.println("음속비행");
		}else {
			super.fly(); // 부모 클래스의 fly
		}
	}
	
	
	public int getSoundSpeed() {
		return soundSpeed;
	}
	public void setSoundSpeed(int soundSpeed) {
		this.soundSpeed = soundSpeed;
	}
	public int getMaxSpeed() {
		return maxSpeed;
	}
	public void setMaxSpeed(int maxSpeed) {
		this.maxSpeed = maxSpeed;
	}
	
}
