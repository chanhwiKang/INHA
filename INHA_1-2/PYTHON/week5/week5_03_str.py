name = "asd"
age = 111
height = 180
data1 = 41.56789
data2 = 50.0

print(data1, data2)
print(f"{data1:.2f}") # 소수점 3자리에서 올림, 41.57
print(f"{data2:g}") # 소수점 제거, 50

# f-string
print(f"{name}의 나이는 {age}살 입니다.")

# format()메소드 이용
data = "{0}의 키는 {2}, {0}의 나이는 {1}살 입니다.".format(name, age, height)
print(data)

data = "{0}의 나이는 {1}살 입니다.".format(name, age)
print(data)

data = "{}의 나이는 {}살 입니다.".format(name, age)
print(data)

# 전통적인 파이썬 동적 문자열 생성
data = "%s의 나이는 %d살입니다." % (name, age)
print(data)

# +연산자 이용
data = "이름" + name + "나이" + str(age)
print(data)

# print()로 나열한 방법
print("이름:", name, "나이", age)
