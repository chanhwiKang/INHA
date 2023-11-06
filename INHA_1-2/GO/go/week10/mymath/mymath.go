package mymath

func MyAbs(n int) int {
	if n < 0 {
		return n * -1
	}
	return n
}
func MyPower(a int, n int) int {
	result := 1
	for i := n; i > 0; i-- {
		result = result * a
	}
	return result
}
