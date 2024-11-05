package week11;

public class Tetris extends Game{
	public Tetris(String title, String version) {
		super(title, version);
	}
	@Override
	public void gameDesc() {
		System.out.println("테트리스는 여기저기에서 시작되어...");
	}
}
