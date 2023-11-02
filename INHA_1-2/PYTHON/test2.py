print("1~10사이의 숫자 중 홀수의 합: ", end="")
count = 0
summary = 0

while count < 10 :
    count += 1
    if count %2 == 0:
        continue
    summary += count
print(summary)
# 1, 3, 5, 7, 9
print("1~10사이의 숫자 중 홀수의 합: ", end="")
count = 0
summary = 0
while count < 10 :
    count += 1
    if count %2 == 0:
        pass
    summary += count
print(summary)