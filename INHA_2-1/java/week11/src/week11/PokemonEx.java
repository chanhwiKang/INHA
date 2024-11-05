package week11;

public class PokemonEx {
	public static void main(String[] args) {
		Pokemon[] pokemons = new Pokemon[3];
		pokemons[0] = new Pikachu();
		pokemons[1] = new Pairi();
		pokemons[2] = new Purin();
	
		for (Pokemon p : pokemons)
			p.introduce();
	}
}
