# 중복 안됨, 순서 없음
my_set={1,2,3,3,3}
print(my_set) # {1, 2, 3}
java: set
java = {"yu", "kim", "yang"}
python = set(["yu", "park"])

# 교집합
print(java & python) # {'yu'}
print(java.intersection(python)) # {'yu'}

# 합집합
print(java | python) # {'yu', 'park', 'kim', 'yang'}
print(java.union(python)) # {'yu', 'park', 'kim', 'yang'}

# 차집합: 자바는 가능하지만, 파이썬은 안되는 개발자
print(java - python) # {'yang', 'kim'}
print(java.difference(python)) # {'yang', 'kim'}

# 파이썬 할 수 있는 사람 추가
python.add("tae")
print(python) # {'park', 'tae', 'yu'}

# java를 잊음
python.remove("tae")
print(python) # {'park', 'yu'}