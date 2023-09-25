d = dict()
for _ in range(int(input())) :
    book = input()
    if book in d :
        d[book] += 1
    else:
        d[book] = 1
candi = []
m = max(d.values())
for k, v in d.items():
    if v == m :
        candi.append(k)

print(sorted(candi)[0])