//학생의 이름과 성적을 입력받고, 성적의 평균을 계산하여 출력하는 프로그램.
package week1;

class Calcultator{
	int left, right;
	public Calcultator(int left, int right) {
		this.left = left;
		this.right = right;
	}
	public void sum() {
		System.out.println(this.right + this.left);
	}
	public void avg() {
		System.out.println((this.right + this.left) / 2);
	}
}

class Substractor extends Calcultator{
	public Substractor(int left, int right) {
		super(left, right);
	}

	public void substract() {
		System.out.println(this.left - this.right);
	}
}
public class CalculatorExample {
	public static void main(String[] args) {
		Substractor c1 = new Substractor(30, 20);
		
		c1.sum();
		c1.avg();
		c1.substract();
	}
}