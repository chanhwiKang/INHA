print("a" + "b") # ab
print("a" , "b") # a b

# 방법 1
print("나는 %d살입니다." % 20)
print("나는 %s을 좋아해요" % "파이썬")
print("Apple 은 %c로 시작해요" % "A")

print("나는 %s, %s을 좋아해요" % ("파랑", "빨강"))

# 방법 2
print("나는 {}살입니다." .format(20))
print("나는 {}, {}을 좋아해요" .format("파랑", "빨강"))
print("나는 {1}, {0}을 좋아해요" .format("파랑", "빨강"))

# 방법 3
print("나는 {age}살이며, {color}색을 좋아해요" .format(age = 20, color="red"))

# 방법 4
age = 20
color = "red"
print(f"나는 {age}살이며, {color}색을 좋아해요")