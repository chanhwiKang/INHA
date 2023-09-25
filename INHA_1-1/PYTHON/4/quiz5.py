from random import *

cnt = 0

for customer in range(1, 51):
    time = randint(5, 51)
    if 15 >= time >= 5: 
        succes = "O"
        cnt += 1
    else:
        succes = " "
    print(f"[{str(succes)}] {customer}번째 손님 (소요시간 : {time}분)")

print(f"\n총 탑승 승객 : {cnt}명")

