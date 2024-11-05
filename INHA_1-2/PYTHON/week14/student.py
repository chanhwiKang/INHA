import datetime as dt
import random
import os

class Student:
    # strftime(), f = format, datetime -> str
    # strptime(), p = parsing, str -> datetime

    
    # 2023-11-30
    time_format = "%Y-%m-%d" # 클래스 변수
    # 20231130 15:31:35
    time_format = "%Y%m%d %H:%M:%S" # 클래스 변수
    # 2023-11-30 15:31:35
    time_format = "%Y-%m-%d %H:%M:%S" # 클래스 변수

    def __init__(self, num, name, kor=0, math=0, eng=0, regdate=None) -> None:
        self.num = num
        self.name = name
        self.kor = kor
        self.math = math 
        self.eng = eng
        if regdate == None:
            day = random.randrange(-2, 3) # 2일 전부터 2일 후까지의 값이 랜덤 생성
            self.regdate = dt.datetime.now() + dt.timedelta(days=day) # 현재 날짜 + 랜덤 값(일 단위)
        else:
            self.regdate = regdate

    def get_sum(self):
        return self.eng + self.math + self.kor
    
    def get_average(self):
        return self.get_sum()/3
        
    def make_record(self):
        str_time = dt.datetime.strftime(self.regdate, Student.time_format) # class소속 변수 사용
        return f"{self.num}|{self.name}|{self.kor}|{self.math}|{self.eng}|{str_time}\n"
    
    def __str__(self) -> str:
        return f"이름: {self.name}, 학번: {self.num}, 평균: {self.get_average():0.1f}"
    
    # 이하 시험 x
    def __gt__(self, value): # A > B ?
        if isinstance(value, Student): # value가 Student 타입인지 확인
            return self.get_sum() > value.get_sum()
        
    def __lt__(self, value): # A < B ?
        if isinstance(value, Student): # value가 Student 타입인지 확인
            return self.get_sum() < value.get_sum()
        
    def __eq__(self, value): # A == B ?
        if isinstance(value, Student): # value가 Student 타입인지 확인
            return self.get_sum() == value.get_sum()
        
    def __ne__(self, value): # A == B ?
        if isinstance(value, Student): # value가 Student 타입인지 확인
            return self.get_sum() != value.get_sum()

if __name__ == "__main__":
    target_path = "/Users/gangchanhwi/Desktop/INHA/INHA_1-2/PYTHON"
    # target_path = "/Users/gangchanhwi/Desktop/bb"
    target_file = "scores.txt"
    
    # target_full_file = target_path + "/" + target_file
    target_full_file = os.path.join(target_path, target_file)
    students = []
    if os.path.exists(target_full_file): # 파일이 존재하는가?
        '''123|김인하|100|80|90|2023-11-30 19:17:20\n'''
        '''123|김인하|100,80,90|2023-11-30 19:17:20\n -> 이 경우도 해보기'''
        with open(target_full_file, "r", encoding="utf-8") as file:
            for record in file:
                record = record.strip()
                fields = record.split("|")
            if len(fields) == 6:
                num = fields[0]
                name = fields[1]
                kor = int(fields[2])
                math = int(fields[3])
                eng = int(fields[4])
                regdate = dt.datetime.strptime(fields[5], Student.time_format)
                students.append(Student(num, name, kor, math, eng, regdate))
    # (1) 입력될때마다 파일에 저장

    # (2) 신규입력을 모두 받고, 해당 데이터를 한꺼번에 추가

    # (3) 기존+신규 모두 새로 저장하기(기존 데이터가 바뀔 수 있는 경우)
    # student = Student()
    '''students = [
        Student(123, "김인하", 100, 80, 90, regdate=dt.datetime.now()), 
        Student(124, "이인하", 100, 80, 90), 
        Student(125, "박인하"),
    ]
    # for stu in students:
        # print(stu.name)
        # print(stu.num)
        # print(stu.kor, stu.math, stu.eng)
        # print(stu.get_sum(), stu.get_average())
        # print(stu)
        # print(stu.make_record())
    # print(students[0] == students[1])
    # print(students[0] != students[1])
    # print(students[2] > students[1])
    # print(students[2] < students[1])
        
    if not os.path.exists(target_path): # 경로가 없으면
        os.mkdir(target_path)
    with open(target_full_file, "a", encoding="utf-8") as file:
        for stu in students:
            file.write(stu.make_record())'''