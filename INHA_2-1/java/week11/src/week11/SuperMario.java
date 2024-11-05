package week11;

public class SuperMario extends Game{
	public SuperMario(String title, String version) {
		super(title, version);
	}
	@Override
	public void gameDesc() {
		System.out.println("슈퍼마리오는 나에서 시작되어...");
	}
}
