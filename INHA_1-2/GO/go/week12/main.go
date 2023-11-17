package main

import "fmt"

func main() {
	// 방법 1
	// var s []int
	// s = make([]int, 5)

	// 방법 2
	// s := make([]int, 5)

	// 방법 3 slice literal
	s := []int{0, 1, 2, 3, 4}

	s[4] = 99

	for _, v := range s {
		fmt.Println(v)
	}

	copyS := s[1:4]
	for _, v := range copyS {
		fmt.Println(v)
	}

	for i := 0; i < len(s); i++ {
		fmt.Println(s[i])
	}

	a := make([]string, 4, 5)
	fmt.Println(a)
	a[0] = "a"
	a[2] = "c"
	a[3] = "d"

	// fmt.Println(a, len(a), cap(a))
	// fmt.Printf("%x %x %x\n", &a[0], &as[0], &a[1])
	// c := append(a, "y") // cap이 충분해서 늘어나지 않는다
	c := append(a, "y", "x") // cap이 부족해서 늘어남
	fmt.Println(a, len(a), cap(a))
	fmt.Println(c, len(c), cap(c)) // len이 cap을 넘어서면 cap이 기존 cap의 배수만큼 늘어남
}
