## 함수 선언 부분 ## 
def printPoly(t_x, p_x) :
	poly_str = "P(x) = "
	
	for i in range(len(px)) :
		coef = p_x[i]	# 계수 px = [7, -4, 5]
		term = t_x[i] 	# 지수 tx = [300, 20, 0]

		if coef >= 1 and i != 0 :
			poly_str += "+"
		poly_str += f"{coef}x^{term} "

	return poly_str


def calcPoly(xVal, t_x, p_x) :
	ret_value = 0
	
	for i in range(len(px)) :
		coef = p_x[i]	# 계수
		term = t_x[i]
		ret_value += coef * xVal ** term
		

	return ret_value


## 전역 변수 선언 부분 ## 

#px = [7, -4, 0, 5]			# = 7x^3 -4x^2 +0x^1 +5x^0 
tx = [300, 20, 0]
px = [7, -4, 5]

## 메인 코드 부분 ## 
if __name__ == "__main__" :

	p_str = printPoly(tx, px)
	print(p_str)

	x_value = int(input("X 값--> "))

	px_value = calcPoly(x_value, tx, px)
	print(px_value)

	
