#for waiting_num in [0, 1, 2, 3, 4]: # [ ]안의 값을 순차적으로 넣은 후 for문 종료
#    print("대기번호 : {}" .format(waiting_num)) 

#위의 for문과 동일
#for waiting_num in range(5): # 0~4, range(1, 6) = 1~5
#    print("대기번호 : {}" .format(waiting_num)) 

starbucks = ["kim", "yee", "kang"]
for customer in starbucks: # customer에 starbuck를 넣음
    print("{}, coffe is ready" .format(customer)) # customer의 값을 넣어 순차적으로 출력