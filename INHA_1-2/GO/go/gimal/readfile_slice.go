package main

import (
	"bufio"
	"fmt"
	"log"
	"os"
	"strconv"
	"strings"
)

func sliceAppend(input_float float64) ([]float64, error) {
	tmp_slc := []float64{}
	file, err := os.Open("/Users/gangchanhwi/Desktop/INHA/INHA_1-2/GO/go/gimal/text/data.txt")
	if err != nil {
		return nil, err
	}
	scanner := bufio.NewScanner(file)
	for scanner.Scan() {
		file_float, err := strconv.ParseFloat(scanner.Text(), 64)
		if err != nil {
			return nil, err
		}
		tmp_slc = append(tmp_slc, file_float)
	}
	tmp_slc = append(tmp_slc, input_float)
	return tmp_slc, nil

}
func main() {
	reader := bufio.NewReader(os.Stdin)
	input, err := reader.ReadString('\n')
	if err != nil {
		log.Fatal(err)
	}
	input = strings.TrimSpace(input)
	input_float, err := strconv.ParseFloat(input, 64)
	if err != nil {
		log.Fatal(err)
	}
	fmt.Println(sliceAppend(input_float))
}
