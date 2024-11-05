import os
from datetime import datetime as dt

dir_name = os.listdir("/Users/gangchanhwi/Desktop/INHA/INHA_1-2/PYTHON/week13")
print(dir_name)
def menu():
    print()
    print("1")
    print("2")
    print("3")
    return input(">").strip()
# print(menu())
car_list = [
    {'number': 1234, 'intime': 1111},
    {'number': 5678, 'intime': 2222},
]
for i, car in enumerate(car_list):
    print(i, car)
a = 50
print(f"asdf{a:10}")

# f"{a:10}" -> 앞에 빈칸 10개 후 변수 출력
# return input(">").strip() -> 입력받은 닶 return