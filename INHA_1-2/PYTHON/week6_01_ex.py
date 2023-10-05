# week5_03_str의 복습
name = input("이름: ")
age = int(input("나이: "))

intro = "이름:%s 나이:%d" % (name, age)
print(intro)

intro = "이름:{} 나이:{}".format(name, age)
print(intro)

print("-"*50)

print("이름:", name, " 나이:", age, sep="")
print("이름:" + name + " 나이:" + str(age))
print(f"이름:{name} 나이:{age} ")