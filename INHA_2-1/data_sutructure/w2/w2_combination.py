# nCr

def factorial(number) -> int:
    """
    Defines a function that receives an integer and returns a factual value to an integer
    """
    result = 1;
    for i in range(2, number + 1) :
        result = result*i
    return result

def nCr(n: int, r: int) -> int :
    """
    Define a function that receives values of n and c and returns the result of the combination to an integer
    """
    return int(factorial(n) / (factorial(n - r) * factorial(r)))
    
print(nCr(7, 2))