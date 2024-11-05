start = int(input("start num: "))
end = int(input("end num: "))
for num in range(start, end+1):
    i=2
    is_prime = True
    while i*i<=num:
        if num%i==0:
            is_prime = False
            break
        i += 1
    if is_prime:
        print(num, end=" ")
    is_prime = True