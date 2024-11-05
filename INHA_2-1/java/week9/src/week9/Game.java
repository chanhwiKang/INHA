package week9;

public class Game {
	private String title;
	private double version;
	
	public Game(String title, double version) {
		this.title = title;
		this.version = version;
	}
	public String getTitle() {
		return title;
	}
	public double getVersion() {
		return version;
	}
	static public String start() {
		return "게임을 시작합니다.";
	}
}
