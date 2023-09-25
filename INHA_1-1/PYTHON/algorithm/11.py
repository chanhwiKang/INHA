age = int(input())

p962 = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j"]
ans = []
a = age//1000
age -= a * 1000
b = age//100
age -= b * 100
c = age//10
d = age%10

ans.append(p962[a])
ans.append(p962[b])
ans.append(p962[c])
ans.append(p962[d])

while True:
    if ans[0] == "a":
        del ans[0]
    else :
        break

print("".join(ans))