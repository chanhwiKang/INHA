score = 600
socnum = "111111-1111111"

print("-" in socnum, "-" not in socnum)

# 같은 출력, 다른 방법
print(not (score == 600), score != 600)
print(score >= 500 and score <= 700, 500 <= score <= 700, not score < 500 and score <= 600)

car = "KIA"
print(car == "Kia")
print(car.lower() == "kia") # car 변수의 문자열을 소문자로 바꿈
print(car.lower() == "bmw")