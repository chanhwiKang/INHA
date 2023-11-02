def call_3_times(func):
    for i in range(3):
        func(i)

def print_hello(i):
    print(f"{i+1} 안녕")
def print_bye(i):
    print(f"{i+1} 꺼져")

call_3_times(print_hello)
call_3_times(print_bye)

# 323pg

a = ["1", "2", "3"]
# a = [int(i) for i in a]
a = map(int, a)
b = sum(a)
print(b)

def test(num): # 밑에거랑 같음
    return num + 1
a = [1, 2, 3]
b = map(test, a)
c = list(b)
print(c)

a = [1, 2, 3]
b = map(lambda num: num + 1, a) # lambda 매개변수: 리턴값
c = list(b)
print(c)

def under_3(item):
    return item < 3

list_data_a = [1, 2, 3, 4 ,5]

output_data = filter(under_3, list_data_a) # 아래랑 같음
print(output_data, list(output_data))
output_data = filter(lambda x: x < 3, list_data_a)
print(output_data, list(output_data))

add = lambda x, y: x + y
print(add(1, 2)) # 람다로 만들고, 함수처럼 호출
print(add(2, 3))