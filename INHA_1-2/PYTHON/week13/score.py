# 성적 관리 class

class Score1:
    def __init__(self) -> None:
        self.kor = 0
        self.eng = 0
        self.math = 0

class Score2:
    def __init__(self, kor = 0, eng = 0, math = 0) -> None:
        self.kor = kor
        self.eng = eng
        self.math = math
    def __str__(self) -> str:
        return "메롱"

class Score3:
    def __init__(self, kor = 0, eng = 0, math = 0) -> None:
        self.scores = {}
        self.scores["kor"] = kor
        self.scores["eng"] = eng
        self.scores["math"] = math
    def __str__(self) -> str:
        length = len(self.scores)
        total = sum(self.scores.values())
        if length > 0:
            avg = total / length
            return f"평균:{avg:0.2f}"
        else:
            return "과목수가 0개입니다."

# * : 가변 매개변수 -> tuple
class Score4:
    def __init__(self, *scores) -> None:
        self.scores = {}
        for score in scores:
            self.scores[score] = 0

    def __str__(self) -> str:
        length = len(self.scores)
        total = sum(self.scores.values())
        if length > 0:
            avg = total / length
            return f"평균:{avg:0.2f}"
        else:
            return "과목수가 0개입니다."

# ** : 키워드 가변 매개변수 -> dict
# score5 = sc.Score5(key1 = value1, key2 = value2) do2.py 28line
class Score5:
    def __init__(self, **scores) -> None:
        self.scores = scores

    def __str__(self) -> str:
        length = len(self.scores)
        total = sum(self.scores.values())
        if length > 0:
            avg = total / length
            return f"평균:{avg:0.2f}"
        else:
            return "과목수가 0개입니다."
        
class Score:
    def __init__(self, **scores) -> None:
        self.scores = scores

    def add_subject(self, subject, score=0):
        if None == self.scores.get(subject):
            self.scores[subject] = score
            return True
        return False
    
    def get_average(self):
        total = sum(self.scores.values())
        length = len(self.scores)
        if length > 0:
            avg = total / length
            return avg
        else:
            return "과목수가 0개입니다."

    def __str__(self) -> str:
        avg = self.get_average()
        if type(avg) == int:
            return avg
        else: 
            return "과목수가 0개입니다."
