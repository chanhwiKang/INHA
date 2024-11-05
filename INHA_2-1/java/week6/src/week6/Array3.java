package week6;
import java.util.*;
public class Array3 {
	public static void main(String[] args) {
//		int[] arrs = new int[10];
//		int sum=0;
//
//		for (int i=0; i<arrs.length; i++) {
//			arrs[i] = (int) (Math.random() * 100);
//			sum += arrs[i];
//			System.out.printf("arrs[%d] = %d\n", i , arrs[i]);
//		}
//		System.out.printf("배열의 총 합 : %d\n", sum);
//		System.out.printf("배열의 평균 : %.1f", (double)sum/arrs.length);
		Scanner sc = new Scanner(System.in);
		int[][] arr = new int[2][3];
		for (int i=0; i<arr.length; i++) {
			for (int j=0; j<arr[i].length; j++) {
				arr[i][j] = sc.nextInt();
				System.out.println(arr[i][j]);
			}
		}
	}
}
