b = "10 20-30 40 50,60"
print("10" in b) # True
print("11" in b) # False
print("12" not in b)

b = "10 20-30 40 50,60"

c = b.split() # 공백을 기준으로 나누기. b.split(" ")과 같음. 리스트로 반환
print(c)

c = b.split("-") # -을 기준으로 나누기
print(c)
print()

a = "       hello Python!   "

print(a.find("o"))
print(a.find("O")) # 값이 없으면 -1 반환
print(a.rfind("o")) # 오른쪽 부터 탐색
print()

print(f"[{a.strip()}]") # 양쪽 공백 제거
print(f"[{a.rstrip()}]") # 오른쪽 공백 제거

# 문자열만 갖고있는 메소드
print(a.upper()) # 대문자로 변환
print(a.lower()) # 소문자로 변환
print(a.title()) # 단어 첫 글자 대문자로 변환