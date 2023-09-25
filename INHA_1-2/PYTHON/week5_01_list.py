price = [2000, 3000, 3500]
number = []
number.append(int(input("강아지 판매 개수:")))
number.append(int(input("고양이 판매 개수:")))
number.append(int(input("레서판다 판매 개수:")))

print(f"{price}\n{number}")

sales = price[0] * number[0]
sales = sales + (price[1] * number[1])
sales = sales + (price[2] * number[2])

print(f"총 매출: {sales}")