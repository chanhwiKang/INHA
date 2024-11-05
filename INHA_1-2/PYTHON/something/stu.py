import random
import datetime as dt
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