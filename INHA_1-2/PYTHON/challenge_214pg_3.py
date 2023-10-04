numbers = [273, 103, 5, 32, 65, 9, 72, 800, 99]

for i in numbers:
    if i % 2 == 0:
        print(f"{i}는 짝수")
    else : print(f"{i}는 홀수")

print("-"*50)

for i in numbers:
    if i // 100 != 0:
        print(f"{i}는 3자리수")
    elif i // 10 != 0: 
        print(f"{i}는 2자리수")
    else : (f"{i}는 1자리수")
