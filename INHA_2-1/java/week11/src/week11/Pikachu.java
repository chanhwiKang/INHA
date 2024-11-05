package week11;

public class Pikachu extends Pokemon {
	@Override
	public void name() {
		System.out.println("이름 : 피카츄, 속성 : 번개");
	}@Override
	public void attack() {
		System.out.println("공격 스킬 : 백만볼트");
	}@Override
	public void passive() {
		System.out.println("패시브 스킬 : 스피드\n");
		
	}
}
