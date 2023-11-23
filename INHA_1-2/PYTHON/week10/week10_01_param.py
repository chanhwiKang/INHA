# 284pg
def info(name, grade):
    print(f"{name} {grade}")

# info("장은미")
info("장은미", 1)
info(1, "장은미")

def reg(name, grade = 1): # grade의 기본 값으로 1을 넣음. 매개변수가 없으면, 1로 자동으로 채워짐
    print(f"{name} {grade}")

reg("김인하")
reg("김인하", 2)


# def reg(grade = 1, name): # 기본값 매개변수 뒤에는, 일반 매개변수가 올 수 없다.
#     print(f"{name} {grade}")

# reg("김인하")

print("김인하")
print()
print("1", "2", "3")

# 280pg 키워드 매개변수
def intro(name, grade=1, hobby="없음"):
    print(f"이름:{name}")
    print(f"학년:{grade}")
    print(f"취미:{hobby}")

intro("김인하") # 포지셔널 매개변수 사용
print()
intro("김인하", "없다") # 포지셔널 매개변수 사용
print()
intro("김인하", hobby="디아4") # 키워드 매개변수 (hobby)
print()
intro(name="김인하", hobby="디아4") # 키워드 매개변수 (name, hobby)
print()
intro(hobby="디아4", name="김인하") # 키워드 매개변수 (name, hobby)
print()
# intro(hobby="디아4", grade=2) # name의 값이 없어서 Err. name은 기본값 매개변수가 아님

#278pg 가변 인자 (*args)
def intro(name, grade, *hobbies): # *hobbies = 가변 인자(가변 매개변수)
    print(name, grade)
    if 0 < len(hobbies):
        print(hobbies)
    else:
        print(hobbies)
        print("없다")
intro("김인하", 3) # 가변 인자는 값을 안넣어도 문제 없음. 빈 tuple이 만들어짐
intro("김인하", 3, "디아4") # tuple형태로 묶여서 출력됨. 
intro("김인하", 3, "디아4", "디아3", "카트라이더는 이제 없어") # ('디아4', '디아3', '카트라이더는 이제 없어')

def intro(name, *hobbies, grade):
    print(name,grade)
    print(hobbies)

# intro("김미영", "이미영", "최미영", "송미영") # err
intro("김미영", "이미영", "최미영", grade="송미영")

def intro(name, *hobbies, grade=1): # 가변 매개변수 뒤에는 기본값 매개변수를 넣는편이 좋다.
    print(name,grade)
    print(hobbies)
intro("김미영", "이미영", "최미영", "송미영")
intro("김미영", "이미영", "최미영", grade="송미영")