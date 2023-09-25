# 빠른 입출력
import sys
t = int(sys.stdin.readline())
for _ in range(t):
    a, b = map(int, sys.stdin.readline().split())
    print(a+b)

# int형으로 여러 입력 받기
test1, test2 = map(int, input().split())
test3, test3 = map(int, sys.stdin.readline())