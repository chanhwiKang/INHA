# # 방법 1
# from student import Student1

# print("step1", "-" * 10)
# stu1 = Student1()

# 방법 2
import student as st

print("step1", "-" * 10)
stu1 = st.Student1() # 생성자 호출
print(stu1)

print("step2", "-" * 10)
stu2 = st.Student2()
print(stu2)
# print(stu2.name) err 'name'속성이 없다. 

print("step3", "-" * 10)
stu3 = st.Student3()
stu4 = st.Student3()
print(stu3)
print(stu4)
stu4.name = "김인하"
stu3.number = "1234"
print(stu3.name)
print(stu4.name)
print(stu3.number)
print(stu3.major)

print("step4", "-" * 10)
# stu4 = st.Student4()  err Student4 method에 필요한 매개변수가 없음
# print(stu4)
stu4 = st.Student4("김인하", "20230001", "컴정")
print(stu4)
print(stu4.name)
print(stu4.number)
print(stu4.major)

stu5 = st.Student4("김인하", "20230001")
print(stu5)
print(stu5.name)
print(stu5.number)
print(stu5.major)

print("step5", "-" * 10)
stu_list = []
while True:
    name = input("이름:")
    number = input("학번:")
    major = input("전공:")
    stu_list.append(st.Student4(name, number, major))

    if input("continue?(Y or N)").lower() == "n":
        break
for stu in stu_list:
    print(stu)