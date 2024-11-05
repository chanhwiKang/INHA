package week10;

public class CarBasicEx {

	public static void main(String[] args) {
		CarBasic car = new CarBasic();
//		car.company = "현대자동차";
		car.setCompany("현대자동차");
		System.out.println(car.getCompany());
	}

}
