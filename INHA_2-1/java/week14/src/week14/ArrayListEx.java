package week14;
import java.util.*;
public class ArrayListEx {
	public static void main(String[] args) {
		List<String> list = new ArrayList<String>();
	
		int idx = 0;
		
		list.add("java");
		list.add("OOP");
		list.add("객체지향프로그래밍");
		
		int size = list.size();
		System.out.println("list size: " + size);
		
		String item = list.get(2);
		System.out.println("list index2:" + item);
		System.out.println();
		
		for (String s: list) {
			System.out.println(idx++ + " : " + s);
		} System.out.println();
		
		list.remove(1);
		idx = 0;
		
		for (String s: list) {
			System.out.println(idx++ + " : " + s);
		} System.out.println();
		
		list.remove(1);
		idx = 0;
		
		for (String s: list) {
			System.out.println(idx++ + " : " + s);
		} System.out.println("------------------------");

		List<String> vector = new Vector<String>();
		vector.add("hong");
		vector.add("lee");
		for (String s : vector) {
			System.out.println(s);
		} System.out.println("------------------------");
	
		List<String> linkedList = new LinkedList<>();
		linkedList.add("apple");
		linkedList.add("melon");
		linkedList.add("banana");
		for (String s : linkedList) {
			System.out.println(s);
		} System.out.println();

		linkedList.remove("apple");
		for (String s : linkedList) {
			System.out.println(s);
		} System.out.println("------------------------");
		
		Map<String, String> map = new HashMap<>();
		map.put("name", "Hong");
		map.put("gender", "Male");
		map.put("id", "admin");
		map.put("pw", "1234");
		for (String s : map.keySet()) {
			System.out.println(s + " = " + map.get(s));
		} System.out.println("------------------------");
		
		Set<String> keyset = map.keySet();
		Iterator<String> keyIter = keyset.iterator();
		
		while(keyIter.hasNext()) {
			String k = keyIter.next();
			System.out.println(k + " : " + k.hashCode());
		}
	}
}
