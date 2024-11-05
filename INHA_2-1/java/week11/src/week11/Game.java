package week11;

public abstract class Game {
	private String title;
	private String version;
	
	public Game(String title, String version) {
		this.title = title;
		this.version = version;
	}
	
	public void start() {
		System.out.println("제목 : " + title);
		System.out.println("버전 : " + version);
		System.out.println(title + "게임을 시작합니다.");	
	}
	
	// 게임에 대한 설명이 필요 => 게임마다 다르게 적용. 추상 메소드로 정의
	public abstract void gameDesc();
}
