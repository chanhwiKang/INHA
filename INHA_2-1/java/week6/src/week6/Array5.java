package week6;
import java.util.*;
public class Array5 {
	public static void main(String[] args) {
		String[] sArray = new String[3];
		sArray[0] = "java";
		sArray[1] = "java";
		sArray[2] = new String("java");
		
		System.out.println("sArray[0], [1]: "+(sArray[0]==sArray[1]?"참조가 같다.":"참조가 다르다."));
		System.out.println("sArray[0], [2]: "+(sArray[0]==sArray[2]?"참조가 같다.":"참조가 다르다."));
		
		if (sArray[0].equals(sArray[2]))
			System.out.println("참조가 같다.");
		else
			System.out.println("참조가 다르.");
		
		// 배열 복사.
		int[] arr1 = {1, 2, 3, 4, 5};
		int[] arr2 = new int[7];
		for (int i=0; i<arr1.length; i++) 
			arr2[i] = arr1[i];
		for (int i=0; i<arr2.length; i++)
			System.out.print(arr2[i]+" ");
		System.out.println();
		
		// System.arraycopy() method 사용.
		System.arraycopy(arr1, 0, arr2, 0, arr1.length);
		for (int i=0; i<arr2.length; i++)
			System.out.println("System.arraycopy: "+arr2[i]+" ");
		
		// Arrays Class 사용.
		arr2 = Arrays.copyOf(arr1, 6);
		for (int i=0; i<arr2.length; i++)
			System.out.println("Arrays.copyOf: "+arr2[i]+" ");
		System.out.println();
		
		// 향상된 for 문
		int[] scores = {1, 2, 3, 4, 5};
		int sum=0;
		for (int i : scores) 
			sum+=i;
		System.out.println(sum);
	}
}
