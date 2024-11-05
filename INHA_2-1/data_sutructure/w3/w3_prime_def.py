def IsPrime(n) -> bool:
    """
    소수 판정 함수
    :param n: 양의 정수
    :return: 소수면 True, 아니면 False
    """
    if n < 2:
        return False
    else:
        i = 2;
        while i*i <= n :
            if n % i == 0:
                return False
            i = i + 1
    return True

start = int(input("input number : "))
end = int(input("input number : "))

for k in range(start, end+1) :
        if IsPrime(k) : 
            print(f"{k}", end=" ")

         
