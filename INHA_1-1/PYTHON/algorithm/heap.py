import heapq
import sys
input = sys.stdin.readline
hq = []

for i in range(int(input())):
    a = int(input())
    if a :
        heapq.heappush(hq, (abs(a), a))
    else:
        print(heapq.heappop(hq)[1] if hq else 0)