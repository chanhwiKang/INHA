# in, not in
a = ["a", "1", 1.1]
print(1 in a)
print("A" not in a)
print("a" not in a)
print("-"*20)

# list.sort, sorted(list)
print()
a = [3, 5, 6, 4, 1]
b = a[:] # 아래처럼 sort 메소드 이용 시 원본이 손상되므로 이와같이 list복사가능
c = sorted(a) # 원본을 손상시키지 않음
d = sorted(a, reverse=True) # 내림차순 정렬도 가능

print(c)
print(d)

print(a)
a.sort() # 오름차순 정렬 = asc
print(a)
a.sort(reverse=True) # 내림차순 정렬 = desc
print(a)
print("-"*20)
# a = "acdza"
# print(a)
# a.sort() # 문자열은 sort속성이 없음(err)
# print(a)

# list.clear()
a = [1, 2, 3, 4, 5]
print(a)
a.clear() # list 안의 요소(element)를 지움. del a[:]랑 같음
print(a)

print("-"*20)

test_list = [1, 2, 3]
add_list = ["a", "b"]

# list.extend()
test_list.extend(add_list) # 기존의 list에 확장함
print(test_list)
print(add_list)

print("-"*20)

result_list = test_list + add_list # 기존의 list에 영향을 미치지 않음
print(test_list + add_list)
print(result_list)
print(test_list)
print(add_list)