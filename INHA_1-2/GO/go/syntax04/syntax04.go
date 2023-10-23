package main

import (
	"bufio"
	"fmt"
	"log"
	"os"
	"strconv"
	"strings"
)

// 자동으로 수를 생성하고, 그것이 소수인지 판가름 하는 프로그램 0.1v
func main() {
	// seed := time.Now().Unix() // 난수 생성을 위한 시드
	// rand.Seed(seed)           // 난수 생성을 위한 시드

	fmt.Print("정수 입력:")
	rd := bufio.NewReader(os.Stdin)
	in, err := rd.ReadString('\n')

	if err != nil {
		log.Fatal(err)
	}

	in = strings.TrimSpace(in) // 불필요한 앞, 뒤 문자 제거
	number, err := strconv.Atoi(in)

	isPrime := true // 변경점
	//number := rand.Intn(150) + 2 // 0과 1제외, 2~151 사이의 수, 난수 생성을 위한 시드
	//fmt.Println("임의로 추출된 수:", number)//난수 생성을 위한 시드

	for i := 2; i < number; i++ { // 1과 number일 때, 루프를 돌지 않는다
		if number%i == 0 {
			isPrime = false
			break
		}
		fmt.Print(i, " ")
	}

	if isPrime {
		fmt.Println(number, "는 소수입니다.")
	} else {
		fmt.Println(number, "는 소수아닙니다.")
	}
}

// package main

// import (
// 	"fmt"
// 	"math/rand"
// 	"time"
// )

// // 자동으로 수를 생성하고, 그것이 소수인지 판가름 하는 프로그램 0.1v
// func main() {
// 	seed := time.Now().Unix()
// 	rand.Seed(seed)

// 	count := 0
// 	number := rand.Intn(150) + 2 // 0과 1제외, 2~151 사이의 수
// 	fmt.Println("임의로 추출된 수:", number)

// 	for i := 1; i <= number; i++ {
// 		if number%i == 0 {
// 			count++
// 		}
// 	}

// 	if count == 2 {
// 		fmt.Println(number, "는 소수입니다.")
// 	} else {
// 		fmt.Println(number, "는 소수아닙다.")
// 	}
// }
