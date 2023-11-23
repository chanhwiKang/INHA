ip_addr = [127, 0, 0, 1]
ip_addr = [str(i) for i in ip_addr] # 문자열이 아니면 에러발생
new_addr = ".".join(ip_addr)
print(new_addr)
###########################################
arr1 = [ i * i for i in range(0, 20, 2) if i % 4]
print(arr1) # [4, 36, 100, 196, 324]

arr = []
for i in range(0, 20, 2):
    if i % 4 :
        arr.append(i * i)
print(arr) # 위 코드와 같다
print()
###########################################
arr1 = [i*i for i in range(0, 20 ,2)]
print(arr1) # [0, 4, 16, 36, 64, 100, 144, 196, 256, 324]

arr = []
for i in range(0, 20, 2):
    arr.append(i*i)
print(arr) # 위 코드와 같다
###########################################
fruits = ["딸기", "사과", "배"]
aa = "asdasdasd"
my_fav = ""
for i in fruits:
    if len(my_fav) > 0 :
        my_fav += ","
    my_fav += i
print(my_fav) # 딸기,사과,배

print(",".join(fruits)) # 딸기,사과,배 위의 뻘짓과 같다.

###########################################
example = {1: "one", 2:"two", 5:"five"}

for i in example:
    print(i) # 1, 2, 5
for i in example.keys():
    print(i) # 1, 2, 5
for i in example.values():
    print(i) # one, two ...
for i in example.items():
    print(i) # (1, 'one') ... 
###########################################
scores = [100, 45, 60, 0, 23]

for i, j in enumerate(scores):
    print(f"{i}번째 인덱스의 값, {j}")

for i, j in enumerate("장인미"):
    print(i, j)
print()

###########################################

scores = [100, 45, 60, 0, 23]
print(list(reversed(scores))) # [23, 0, 60, 45, 100]
print(scores) # [100, 45, 60, 0, 23] 리스트에 변화 없음

rvs = reversed(scores)
for r in rvs:
    print("1st: ", r)
for r in rvs:   # 동작이 안됨. 에러도 안남.
    print("2nd: ", r) # 실제 data를 원한다면, print(list(reversed(scores)))