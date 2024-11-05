start = int(input("input number : "))
end = int(input("input number : "))

for k in range(start, end+1) :
    is_prime = True
    if k < 2:
        is_prime = False
    else:
        i = 2;
        while i*i <= k :
            if k % i == 0:
                is_prime = False
                break
            i = i + 1
        if is_prime : print(k, end=" ")
        is_prime = True

         
