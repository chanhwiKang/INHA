package week10;

public class SmartPhone extends Phone{
	private boolean wifi;
	public SmartPhone(String model, String color) {
		super(model, color);
//		this.model = model;
//		this.color = color;
		System.out.println("Smart Phone 생성자 호");
	}
	
	public boolean isWifi() {
		return wifi;
	}
	public void setWifi(boolean wifi) {
		this.wifi = wifi;
	}
	public void internet() {
		System.out.println("인터넷 연결");
	}
}
