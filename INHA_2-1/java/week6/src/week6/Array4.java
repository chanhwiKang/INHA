package week6;

public class Array4 {

	public static void main(String[] args) {
		int[][] math = new int[2][3];
		// 2차원 배열은 반드시 중첩 for문을 사용.
		for (int i=0; i<math.length; i++) {
			for (int j=0; j<math[i].length; j++) {
				System.out.printf("math[%d][%d] = %d\n", i, j,math[i][j]);
			}
		}
		
		System.out.println();
		// 모든 열의 갯수가 동일하지 않아도 2차원 배열을 만들 수 있다.
		// 배열 생성 시 크기를 생략 수 있다.
		// 행의 갯수는 반드시 필요. 단, 열의 갯수는 생략 가능.
		int[][] eng = new int[2][];
		eng[0] = new int[2];
		eng[1] = new int[3];
		for (int i=0; i<eng.length; i++) {
			for (int j=0; j<eng[i].length; j++) {
				System.out.printf("eng[%d][%d] = %d\n", i, j,eng[i][j]);
			}
		}
		System.out.println();
		
		// 값 목록을 가지고 다차원 배열 생성
		int[][] kor = {{95, 80}, {90, 70, 60}}; 
		for (int i=0; i<kor.length; i++) {
			for (int j=0; j<kor[i].length; j++) {
				System.out.printf("kor[%d][%d] = %d\n", i, j,kor[i][j]);
			}
		}
	}

}
