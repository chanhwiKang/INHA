# 317pg
t = (10, 20, 30)
a = t[0]
b = t[1:] # tuple을 slicing하면 tuple로 나옴
print(a, b, list(b))

t = (10, 20, 30)
for i, j in enumerate(t):
    print(i, j)

a = []
b = [1]
c = ()
d = (1) # int. 값의 우선순위를 조정하는 용도로 쓰이는 ()
e = (1,) # 이렇게 써야 tuple
print(type(a), type(b), type(c), type(d))

a, b = [10, 20] # unpacking: 오른쪽의 군집형을 왼쪽의 변수에 넣음
c, d = (10, 20)
print(type(a), type(b), type(c), type(d))

a = (10, 20, 30) # packing
b = 10, 20, 30 # packing, tuple로 packing됨
print(a, b)
c, d, e = b
print(c, d, e)

# 320pg
# 미친 스왑 기술
a, b = 10, 20
b, a = a, b
print(a, b)
print()

for a in enumerate([1,2,3]):
    b, c = a
    print(a[0], a[1])
    print(b, c)
    print(a)
print()
for i, v in enumerate([1,2,3]):
    print(i, v)
print()

def divide(n1, n2):
    q = n1 // n2
    r = n1 % n2
    return q, r

q, r = divide(10,3)
print(divide(10,3))
print(q, r)

