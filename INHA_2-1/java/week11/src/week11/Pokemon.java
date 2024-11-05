package week11;

public abstract class Pokemon {
	public abstract void name();
	public abstract void attack();
	public abstract void passive();
	
	public void introduce() {
		name();
		attack();
		passive();
	}
}
