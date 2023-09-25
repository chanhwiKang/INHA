for _ in range(int(input())):
    stk = []
    isVps = True
    for ch in input():
        if ch == '(':
            stk.append(ch)
        else :
            if len(stk) > 0: # if stk: 같음
                stk.pop()
            else :
                isVps = False
                break

    if len(stk) > 0:
        isVps = False
    
    print('YES' if isVps else 'NO')