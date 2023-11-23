numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9]
output = [[], [], []]

for i in numbers:
    output[(i-1)%3].append(i)
print(output)