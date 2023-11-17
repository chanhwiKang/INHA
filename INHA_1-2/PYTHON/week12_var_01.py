a = 1
b = 1
c = 1

def vartest1(a):
    a = a + 1
def vartest2(b):
    b = b + 1
    return b
def vartest3():
    # 아래를 주석처리하면?
    global c
    c = c + 1

vartest1(a)
b = vartest2(b)
vartest3()

print(a, b, c)