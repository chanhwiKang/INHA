package main

import (
	"bufio"
	"fmt"
	"log" // add fatal func
	"os"
	"strconv"
	"strings"
)

func main() {
	fmt.Print("단 입력:")
	rd := bufio.NewReader(os.Stdin)
	in, err := rd.ReadString('\n')

	if err != nil {
		log.Fatal(err)
	}

	in = strings.TrimSpace(in) // 불필요한 앞, 뒤 문자 제거
	// dan, err := strconv.ParseInt(in, 10, 32) // str -> int로 바꿈
	dan, err := strconv.Atoi(in) // 위 코드랑 같음

	if err != nil {
		log.Fatal(err)
	}

	for i := 1; i < 10; i++ {
		// fmt.Println(dan, "*", i, "=", (int(dan) * i)) // ParseInt 사용 시
		fmt.Println(dan, "*", i, "=", (dan * i)) // Atoi 사용 시
	}

}

// package main

// import (
// 	"bufio"
// 	"fmt"
// 	"os"
// )

// func main() {
// 	fmt.Print("숫자 입력:")
// 	rd := bufio.NewReader(os.Stdin)
// 	in, _ := rd.ReadString('\n')
// 	fmt.Println(in)
// }
