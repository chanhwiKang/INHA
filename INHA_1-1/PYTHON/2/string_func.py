python = "Python is Amazing"
print(python.lower()) # 모두 소문자로 변경 됨
print(python.upper())
print(python[0].isupper())# 첫 글자가 대문자인가?, True
print(len(python)) # 문장 길이를 세어줌, 17
print(python.replace("Python", "Swift")) # 문자열 중 Python을 찾아서 Swift로 바꿔줌

index = python.index("n") # index변수에 python변수 안에 n의 위치를 입력
print(index)
index = python.index("n", index + 1) # 두번째 n을 찾아 입력
print(index)

print(python.find("n")) #index 함수랑 '같은 점'
print(python.find("Swift")) # 값이 없으면 -1 반환 '다른 점'
#print(python.index("Swift")) # index 함수는 err발생

print(python.count("n")) # n이 몇번 등장하는지