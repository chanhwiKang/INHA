def solution(arr):
    cnt = 0
    var = 0
    answer = [arr.pop()]
    while len(arr) :
        var = arr.pop()
        if answer[cnt] != var :
            answer.append(var)
            cnt += 1
    answer.reverse()
    return answer

arr = [1, 1, 3, 3, 0, 1, 1]
answer = solution(arr)
print(answer)
