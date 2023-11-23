infos = {"123": ["김인하", 22], "124": ["kim", 21]}

num = input("학번:")
if num in infos:
    print(f"이름:{infos[num][0]}")

for i in range(10):
    if i < 8:
        break
    elif i < 4:
        continue
    else: print(i)

fruits = ['a', 'b', 'c', 'c', 'd']

target = "c"
while target in fruits:
    fruits.remove(target)
print(fruits)

i = 0
while i < 5:
    i += 1
