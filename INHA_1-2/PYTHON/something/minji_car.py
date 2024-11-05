import datetime

class Car:
    def __init__(self, number="") -> None:
        # 차량 번호, 입차시간, 출차시간 초기화
        self.number = number  # 차량번호
        self.intime = datetime.datetime.now()  # 입차시간
        self.outtime = None  # 출차시간

    def set_out(self):
        # 출차시 호출하는 메소드
        # 현재 메소드가 호출한 시간으로 출차 시간을 설정한다.
        #출차 시간을 설정한다.
        self.outtime = datetime.datetime.now()

    def is_out(self):
        # 출차를 했는지 여부를 True, False로 반환
        if None != self.outtime :
            return True
        else :
            return False

    def cal_price(self, hour=1500):
        # 주차 요금 계산
        if not self.is_out():
            # 출차하지 않은 경우 현재 시간까지의 주차 요금 계산
            parked_time = datetime.datetime.now() - self.intime
        else:
            # 출차한 경우 출차한 시간을 기준으로 주차 요금 계산
            parked_time = self.outtime - self.intime

        total_hours = parked_time.total_seconds() / 3600
        parking_fee = total_hours * hour # 요금제 선택
        return parking_fee

    def __str__(self) -> str:
        # 차량 번호와 입차시간, 출차시간 또는 '주차중'을 문자열로 조합해서 반환
        if not self.is_out():
            return f"차량번호: {self.number}, 입차시간: {self.intime.strftime('%Y-%m-%d %H:%M:%S')}, 상태: 주차중"
        else:
            return f"차량번호: {self.number}, 입차시간: {self.intime.strftime('%Y-%m-%d %H:%M:%S')}, 출차시간: {self.outtime.strftime('%Y-%m-%d %H:%M:%S')}"