package main

import "fmt"

func main() {
	// var games map[int]string
	// games = make(map[int]string)

	// games := make(map[int]string)
	// 위의 두 가지 방법과 같음.
	games := map[int]string{456: "성기훈", 218: "박해수", 067: "강새벽", 001: "오일남"}

	// games[456] = "성기훈"
	// games[218] = "박해수"
	// games[067] = "강새벽"
	// games[001] = "오일남"
	// games[199] = "알리"
	// games[101] = "IOI"

	for _, v := range games {
		fmt.Println(v)
	}
	games[101] = "장덕수" // update
	delete(games, 199) // delete
	for k, v := range games {
		fmt.Println(k, v)
	}
}
