def findname1(target, cmplist):
    if target in cmplist:
        return True
    return False
def findname2(target, cmplist):
    return isinstance(target, str)

names = ["a", "b", "c"]
result1 = findname1("a", names)
result2 = findname2("a", names)

print(result1, result2)

*a, b, c = 1, 2, 3, 4, 5
print(a, b, c)

numbers = [1, 2, 3, 4, 5]
squared_numbers = list(map(lambda x: x ** 2, numbers))
print(squared_numbers)  # 출력: [1, 4, 9, 16, 25]
