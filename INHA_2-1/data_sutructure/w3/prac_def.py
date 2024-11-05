def Is_prime(num):
    if num < 2:
        return False
    else:
        i=2
        while i*i <= num:
            if num%2==0:
                return False
            i = i + 1
        return True

start = int(input("start num: "))
end = int(input("end num: "))
for num in range(start, end+1):
    if Is_prime(num):
        print(num)