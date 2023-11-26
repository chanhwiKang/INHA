# 202344073, 강찬휘
import datetime

class Car:
    def __init__(self, number) -> None:
        self.number = number # 차량번호
        self.intime = datetime.datetime.now() # 입차시간
        self.outtime = None # 출차시간
    def set_out(self):
        # 출차시 호출하는 메소드. 현재 메소드가 호출한 시간으로 출차 시간을 설정한다
        self.outtime = datetime.datetime.now()
        
    def is_out(self):
        if self.outtime == None:
            return False
        return True
        
    def cal_price(self, hour=2000):
        if self.outtime == None:
            totalSecond = (datetime.datetime.now() -  self.intime).total_seconds()
        else:
            totalSecond = (self.outtime - self.intime).total_seconds()
        return f"{int(totalSecond//3600*hour)}원"
        # 출차를 하지 않은 경우에는 현재 시간까지의 주차 요금을 계산하고
        # 출차를 한 경우에는 출자한 시간을 기준으로 주차 요금을 계산한다.
        # 시간당 2000 원이며, 다른 요금을 적용하고 싶으면 원하는 시간당 요금을 사용할 수 있도록 한다.
        # 두 시간 차이를 구하고 total_seconds()을 이용하면
        # 두 시간 차이를 초 단위로 얻을 수 있다.
        # 이를 이용하여 주차 요금을 계산한다.
        # 계산한 주차 요금을 반환한다.
        
    def __str__(self) -> str:
        # 차량 번호와 입차시간, 출차시간을 적절하게 문자열로 조합해서 반환한다.
        if self.outtime == None:
            intime = datetime.datetime.strftime(self.intime, "%Y-%m-%d %H:%M:%S")
            printInfo = f"차량번호: {self.number}, 입차시간: {intime}, 출차시간: 주차중"
        else:
            intime = datetime.datetime.strftime(self.intime, "%Y-%m-%d %H:%M:%S")
            outtime = datetime.datetime.strftime(self.outtime, "%Y-%m-%d %H:%M:%S")
            printInfo = f"차량번호: {self.number}, 입차시간: {intime}, 출차시간: {outtime}"
        return printInfo