package week9;

public class Area {
	// Method Overloading
	
	// 원의 넓이.
	double areaCal(double radius) {
		return 3.14 * radius * radius;
	}
	// 직사각형의 넓이.
	int areaCal(int witdh) {
		return witdh * witdh;
	}
	// 정사각형의 넓이.
	int areaCal(int width, int height) {
		return width * height;
	}
}
