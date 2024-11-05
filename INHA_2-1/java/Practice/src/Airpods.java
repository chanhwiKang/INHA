
public class Airpods implements EarPhone{
	public Airpods() {
		System.out.println("\nApple Airpods connecting...");
	}
	
	@Override
	public void play() {
		System.out.println("play with Airpods");
	}
	
	@Override
	public void stop() {
		System.out.println("stop music in Airpods");		
	}
}
