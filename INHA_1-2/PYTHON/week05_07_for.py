# 212pg, print(items) -> 오타 있음 
# for
list_of_list = [
    [1, 2, 3],
    [3, 4, 5, 7],
    [10, 11]
]

for i in list_of_list:
    print(i)
    for j in i:
        print(j)
    print()

name = "장은미"
scores = [22, 100, 30, 40]

for i in scores:
    print(i)

for i in name:
    print(i, end="")