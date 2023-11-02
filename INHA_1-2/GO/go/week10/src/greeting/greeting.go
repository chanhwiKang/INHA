package greeting

import "fmt"

func Hello() { // 함수의 이름 첫 글자를 대문자로 해야 외부에서 참조 할 수 있다
	fmt.Println("Hello")
}
func Hi() {
	fmt.Println("Hi")
}
