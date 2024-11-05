# ch = input("ascii code pls: ")
# print(ord(ch)) # mapping된 ascii code 값을 10진수로 return

univ = "inha tec"
print(univ.split()) # list로 return

# input을 split -> 각각을 int로 형변환(map) -> list로 묶음(unpacking시 필요 없음) -> unpacking
start, end = list(map(int, input("Start, End num pls: ").split())) 
print(start, end)
list(map(int, input("asd").split()))