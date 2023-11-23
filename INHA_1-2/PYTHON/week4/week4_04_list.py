# 배열의 특징
# 모든 값이 메모리에 연속적으로 할당
# 고정길이

# 리스트의 특징
# 모든 값이 메모리에 연속적으로 할당 -> x
# 고정길이 -> x

stu_1 = [20230001, "김인하", "컴정", 20]
stu_2 = [20230010, "이인하", "컴시", 21]
print(stu_1[1][1:])
print(stu_1[0]//10000)
print(str(stu_1[0])[:4])

# print(stu_1)
# test_list = [1, 2, 3]
# print(test_list) # [1, 2, 3]

# test_list = list() # 생성자
# print(test_list, type(test_list))
# test_list = [] # 리터럴 형태
# print(test_list, type(test_list))