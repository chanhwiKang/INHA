package week10;

public class CarBasic {
	// 클래스의 필드들은 Private으로 선언해서 외부 접근을 제한한다.
	private String company;
	private String model;
	private String color;
	private int maxSpeed;

	// 외부에서 값이 필요한 경우 getter() method를 이용해서 값을 제공.
	public String getCompany() {
		return company;
	}
	// 외부로부터 주어진 값을 필드로 적용하기위해 setter() method를 이용해서 값을 제공.
	public void setCompany(String company) {
		this.company = company;
	}
	public String getModel() {
		return model;
	}
	public void setModel(String model) {
		this.model = model;
	}
	public String getColor() {
		return color;
	}
	public void setColor(String color) {
		this.color = color;
	}
	public int getMaxSpeed() {
		return maxSpeed;
	}
	public void setMaxSpeed(int maxSpeed) {
		if(maxSpeed > 350) maxSpeed = 350;
		this.maxSpeed = maxSpeed;
	}
	
	
}
