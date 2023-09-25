test = [1, 2, 3]
test[2] = 4 # [1, 2, 4]
# 맨 뒤에 추가
test.append(5) # [1, 2, 4, 5]
test.append(6) # [1, 2, 4, 5, 6]

# 삽입
test.insert(2, 3) # [1, 2, 3, 4, 5, 6]
test.insert(-10, 0) # [0, 1, 2, 3, 4, 5, 6]
test.insert(10, 20) # [0, 1, 2, 3, 4, 5, 6, 20]

# 순서[index]로 삭제
del test[-1] # [0, 1, 2, 3, 4, 5, 6]
del test[2:4]# [0, 1, 4, 5, 6]
del test[:] # [] , 모든 요소 삭제, test.clear()와 같음

test = [0, 1, 4, 5, 6]

# 값[value]으로 삭제
test.remove[6] # [0, 1, 4, 5]

# pop() 삭제 및 요소 반환
a = test.pop() # a = 5, test = [0, 1, 4]
test.pop(1) # [0, 4]

test = [1, 2, 3]

test + [1, 2] # [1, 2, 3, 1, 2]
test * 3 # [1, 2, 3, 1, 2, 3, 1, 2, 3]

len(test) # 3

