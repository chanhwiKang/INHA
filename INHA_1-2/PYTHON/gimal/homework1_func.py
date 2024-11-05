import os
from datetime import datetime as dt

student_list = []
student_num = 0
dir_path = "/Users/gangchanhwi/Desktop/INHA/INHA_1-2/PYTHON/gimal"

def select_menu():
    print("1. 학생 정보 추가")
    print("2. 학생 정보 삭제")
    print("3. 학생 정보 수정")
    print("9. 학생 정보 확인")
    print("0. 프로그램 종료")
    return input("메뉴를 선택해주세요: ").strip()
def make_path(student_num):
    return os.path.join(dir_path, "student"+str(student_num))

def make_save_form(student):
    stu_date = dt.strftime(student.date, "%Y/%m/%d %H:%M:%S")
    tmp_str = f"{student.name}|{student.kor}|{student.eng}|{student.math}|{stu_date}"
    return tmp_str
def make_load_form(student_info):
    tmp_list = student_info.split("|")
    return Student(tmp_list[0], tmp_list[1], tmp_list[2], tmp_list[3], dt.strptime(tmp_list[4], "%Y/%m/%d %H:%M:%S"))
def make_dir(path):
    if not os.path.exists(path):
        os.mkdir(path=path)
def get_student_info():
    name = input("이름을 넣어주세요.(종료시 엔터) : ")
    if not name:
        return False
    kor = input("국어 점수 : ")
    eng = input("영어 점수 : ")
    math = input("수학 점수 : ")
    date = dt.now()
    student_list.append(Student(name, kor, eng, math, date))
    return True
def del_student_info():
    name = input("삭제 할 이름을 입력해주세요.").strip()
    for i, v in enumerate(student_list):
        if v.name == name:
            del student_list[i]
def update_student_info():
    name = input("수정할 학생의 이름을 입력하세요.").strip()
    for v in student_list:
        if v.name == name:
            print("값의 수정을 원치 않는다면, 엔터로 skip")
            kor = input(f"국어성적은 {v.kor}입니다. 수정할 값을 입력하세요 : ")
            eng = input(f"영어성적은 {v.eng}입니다. 수정할 값을 입력하세요 : ")
            math = input(f"수학성적은 {v.math}입니다. 수정할 값을 입력하세요 : ")
            if kor:
                v.kor = kor 
            if eng:
                v.eng = eng
            if math:
                v.math = math
            return True
    return False

def load_student_info():
    files_in_dir = os.listdir(dir_path)
    for v in files_in_dir:
        if v[-3:] != ".py":
            student_list.append(v)
    student_list.sort()
    for i, student in enumerate(student_list):
        with open(make_path(i), "r") as f:
            student_list[i] = make_load_form(f.readline().strip())
    return student_list

def save_student_info():
    for i, student in enumerate(student_list):
        make_dir(dir_path)
        with open(make_path(i), "w") as f:
            f.write(make_save_form(student))
class Student:
    def __init__(self, name, kor, eng, math, date=dt.now()) -> None:
        self.name = name
        self.kor = kor
        self.eng = eng
        self.math = math
        self.date = date
    def __str__(self) -> str:
        return f"{self.name}, {self.kor}, {self.eng}, {self.math}, {self.date}\n"