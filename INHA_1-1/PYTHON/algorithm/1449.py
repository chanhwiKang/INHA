leak, length = map(int, input().split())

pipe = [False] * 1001
tape = 0
for i in map(int, input().split()):
    pipe[i] = True
x = 0
while x < 1001 :
    if pipe[x]:
        x += length
        tape += 1
    else :
        x += 1

print(tape)