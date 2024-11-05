package week11;

public class GameEx {
	public static void main(String[] args) {
		Game[] games = new Game[3];
		games[0] =  new Lol("League Of Legend", "1.1");
		games[1] = new Tetris("Tetris", "11.1");
		games[2] = new SuperMario("SuperMario", "111.1");
		
		for(Game g : games) {
			g.start();
			g.gameDesc();
			System.out.println();
		}
	}
}
