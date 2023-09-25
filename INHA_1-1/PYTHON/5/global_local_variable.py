gun = 10

def checkpoint(soldiers):
    global gun # 전역변수에 있는 gun을 사용함
    gun = gun - soldiers
    print(f"함수 내 남은 총: {gun}")

print(f"전체 총 수: {gun}")
checkpoint(2)
print(f"남은 총 수: {gun}")