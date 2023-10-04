numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9]

for i in range(len(numbers) // 2):
    j = i + i + 1
    print(f"i = {i}, j = {j}")
    numbers[j] = numbers[j] ** 2
print(numbers)
