package main

import "fmt"

func status(name string) {
	balls := map[string]int{"a": 1, "b": 11}
	ball, isBall := balls[name]
	if !isBall {
		fmt.Println(name, "는 map에 없다맨이야")
	} else if ball < 10 {
		fmt.Println(name, "의 ball수", ball, "10개 미만")
	} else {
		fmt.Println(name, "의 ball수", ball, "10개 이상")
	}

}
func main() {
	status("a")
	status("b")
	status("c")
}
