# 학생 정보를 관리하는 class

class Student1:
    pass

class Student2:
    def __init__(self):
        pass

class Student3:
    def __init__(self):
        self.name = ""
        self.number = ""
        self.major = ""

class Student4:
    def __init__(self, name, number, major=""):
        self.name = name
        self.number = number
        self.major = major

    # print()호출 시 이 메소드를 호출. 이거 없으면 타입명과 위치 반환 
    # 모든 class에는 __str__있음
    # '재정의'해서 원하는 문자열로 바꾼 것
    def __str__(self) -> str: 
        return f"{self.name}/{self.number}/{self.major}"