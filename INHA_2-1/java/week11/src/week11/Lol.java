package week11;

public class Lol extends Game{
	public Lol(String title, String version) {
		super(title, version);
	}
	@Override
	public void gameDesc() {
		System.out.println("롤은 영국에서 시작되어...");
	}
}
