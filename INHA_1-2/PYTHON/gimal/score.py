import os
class Score:
    def __init__(self, name, kor ,eng, math) -> None:
        self.name = name
        self.kor = kor
        self.eng = eng
        self.math = math

    def __str__(self) -> str:
        return f"이름:{self.name} 국어:{self.kor} 영어:{self.eng} 수학:{self.math} 평균:{self.avg()}"

    def avg(self):
        return (self.kor + self.eng + self.math) / 3
    
    def file_content():
        pass

path_name = "/Users/gangchanhwi/Desktop/INHA/INHA_1-2/PYTHON/gimal"
full_filename = path_name + "/list.txt"
if os.path.isfile(full_filename):
    with open(full_filename, )