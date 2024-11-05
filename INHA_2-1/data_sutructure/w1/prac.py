num = int(input("num : "))
is_prime = True
if num < 2:
    print(f"{num}is Prime")
else :
    i = 2
    while i*i <= num:
        if num % 2 == 0:
            is_prime = False
            break
        i = i + 1
if is_prime:
    print(f"{num}is Prime")
else :
    print(f"{num}is not Prime")