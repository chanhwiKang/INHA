fruits = ['a', 'b', 'c', 'd']

for i in reversed(range(len(fruits))):
    print(f"{i+1}순위: {fruits[i]}")
    
for i in range(len(fruits)):
    print(f"{i+1}순위: {fruits[i]}")

for i in range(5):
    print(fruits[i])
for i in [0, 1, 2, 3, 4]:
    print("안녕")

# 아래 3개는 출력이 같음
# range_1 = list(range(10))
# range_2 = list(range(1, 10))
# range_3 = list(range(0, 10, 1))
# print(range_1)
# print(range_2)
# print(range_3)