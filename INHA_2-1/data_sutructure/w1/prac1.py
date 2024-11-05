num = int(input("숫자 입력: "))
if num < 2:
    print(f"{num} is not Prime")
else :
    i=2
    isPrime = True
    while i*i<=num:
        if num % i == 0:
            isPrime = False
            break
        i += i
    if isPrime:
        print(f"{num} is Prime")
    else :
        print(f"{num} is not Prime")