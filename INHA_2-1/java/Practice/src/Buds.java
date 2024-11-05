
public class Buds implements EarPhone{
	public Buds() {
		System.out.println("\nSamsung Buds connecting...");
	}
	
	@Override
	public void play() {
		System.out.println("play with Buds");
	}
	
	@Override
	public void stop() {
		System.out.println("stop music in Buds");		
	}
}
