cabinet = {3:"유재석", 100:"김태호"} # key = 3, value = "유재석"
print(cabinet[3]) # 3번과 연결된 유재석 출력
print(cabinet[100])

print(cabinet.get(3)) # 2L과 같음 , 유재석
#print(cabinet[5]) # 없는 key 출력 시 err 발생
print(cabinet.get(5)) #6L과 달리 , None 출력
print(cabinet.get(5, "사용 가능")) # None 출력 대신 '사용 가능' 출력

print(3 in cabinet) # key 3이 cabinet안에 있나? , True
print(5 in cabinet) # False

cabinet = {"A-3":"유재석", "B=100":"김태호"} # 문자열 key도 가능
print(cabinet["A-3"])

print(cabinet) # {'A-3': '유재석', 'B=100': '김태호'}
cabinet["C-20"] = "조세호" # 새 dictionary 추가 
cabinet["A-3"] = "김종국" # 덮어쓰기
print(cabinet) # {'A-3': '김종국', 'B=100': '김태호', 'C-20': '조세호'}

del cabinet["A-3"] # A-3 삭제
print(cabinet) # {'B=100': '김태호', 'C-20': '조세호'}

print(cabinet.keys()) # key만 출력, dict_keys(['B=100', 'C-20'])
print(cabinet.values()) # value만 출력, dict_values(['김태호', '조세호'])
print(cabinet.items()) # 모두 출력, dict_items([('B=100', '김태호'), ('C-20', '조세호')])

cabinet.clear() # 모든 값 삭제
print(cabinet) # {}