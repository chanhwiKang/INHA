package week7;

public class Car2 {
	String model;
	String color;
	int maxSpeed;
	
	Car2 (String model, String color, int maxSpeed){
		this.model = model;
		this.color = color;
		this.maxSpeed = maxSpeed;
	}
	Car2 (String model, String color){
		this(model, color, 100);
	}
	Car2 (String model){
		this(model, "silver", 250);
	}
	Car2(){}
}
