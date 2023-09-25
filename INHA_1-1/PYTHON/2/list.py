subway = [10, 20, 30]
print(subway) # [10, 20, 30]

subway = ["a", "b", "c"]
print(subway) # ['a', 'b', 'c']

print(subway.index("b")) # b가 몇번째에 있는가, # 1

subway.append("d") # d 추가
print(subway) # ['a', 'b', 'c', 'd']

subway.insert(1, "aa") # 1번째에 aa가 들어가고 나머지는 뒤로 한칸씩 이동
print(subway) # ['a', 'aa', 'b', 'c', 'd']

print(subway.pop()) # 가장 뒤에있는 것이 빠짐, d
print(subway) # ['a', 'aa', 'b', 'c']

subway.append("a")
print(subway) # ['a', 'aa', 'b', 'c', 'a']
print(subway.count("a")) # list안에 a가 몇개 들어있는지 확인, 2

num_list = [3,2,5,7,4]
print(num_list) # [3, 2, 5, 7, 4]

num_list.sort() # 정렬
print(num_list) # [2, 3, 4, 5, 7]

num_list.reverse() # 순서 뒤집기
print(num_list) # [7, 5, 4, 3, 2]

num_list.clear() # 내용 다 삭제
print(num_list) #[]

mix_list = ["a", 2, True]
print(mix_list) # 자료형 구분없이 사용 가능

num_list = [3,2,5,7,4]
num_list.extend(mix_list) # num_list에 mix_list를 넣음
print(num_list) # [3, 2, 5, 7, 4, 'a', 2, True]