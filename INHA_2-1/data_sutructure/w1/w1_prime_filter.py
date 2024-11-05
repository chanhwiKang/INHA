num = int(input("input number : "))
is_prime = True
if num < 2:
    print(f"{num} is not prime")
else:
    i = 2;
    while i*i <= num :
        if num % i == 0:
            is_prime = False
            break
        i = i + 1
         
    if is_prime:
        print(f"{num} is prime")
    else:
        print(f"{num} is not prime")
