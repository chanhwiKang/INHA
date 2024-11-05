
public class TonFree implements EarPhone{
	public TonFree() {
		System.out.println("\nLG TonFree connecting...");
	}
	
	@Override
	public void play() {
		System.out.println("play with TonFree");
	}
	
	@Override
	public void stop() {
		System.out.println("stop music in TonFree");		
	}
}
