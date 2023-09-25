from collections import deque

N = int(input())
# dq = deque()
# for i in range(1, N + 1):
#    dq.append(i)
dq = deque((range(1, N + 1))) # 4, 5, 6 line과 같음

while len(dq) > 1:
    dq.popleft() # 가장 앞의 값을 뺌
    dq.append(dq.popleft()) # 가장 앞의 값을 빼고, 그 값을 그대로 맨 뒤로 추가함

print(dq.popleft()) # print(dq)로 출력하면 deque([4]) <- 이렇게 나와서 pop시켜서 정수값 출력