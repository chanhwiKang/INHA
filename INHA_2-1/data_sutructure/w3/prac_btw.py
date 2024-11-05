start = int(input("start num: "))
end = int(input("end num: "))
for num in range(start, end+1):
    is_prime = True
    i = 2
    while i*i <= num:
        if num%i==0:
            is_prime = False
            break
        i = i + 1
    if is_prime:
        print(num)
    is_prime = True