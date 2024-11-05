package week9;

public class GameEx {
	public static void main(String[] args) {
		LOL lol = new LOL("롤", 13.0);
		Tetris tetris = new Tetris("테트리스", 12.5);
		SuperMario supermario = new SuperMario("슈퍼마리오", 15.1);
		
		System.out.println("제목 : " + lol.getTitle());
		System.out.println("버전 : " + lol.getVersion());
		System.out.println(lol.getTitle() + Game.start());
		lol.lolDesc();
		System.out.println();
		
		System.out.println("제목 : " + tetris.getTitle());
		System.out.println("버전 : " + tetris.getVersion());
		System.out.println(tetris.getTitle() + Game.start());
		tetris.tetrisDesc();
		System.out.println();

		System.out.println("버전 : " + supermario.getVersion());
		System.out.println("제목 : " + supermario.getTitle());
		System.out.println(supermario.getTitle() + Game.start());
		supermario.marioDesc();
		System.out.println();
		
	}
}
