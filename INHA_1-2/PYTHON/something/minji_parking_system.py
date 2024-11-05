import datetime
from minji_car import *

if __name__ == "__main__":
    car1 = Car("123 가 1234")
    car2 = Car("123 가 1235")
    print(car1) # 차량번호와 입차시간, "주차중"이라는 것이 출력되야 한다.
    print(car2) # 차량번호와 입차시간, "주차중"이라는 것이 출력되야 한다.
    print("출차" if car1.is_out() else "주차중")
    print("출차" if car2.is_out() else "주차중")

    car2.set_out() # 출차 시 실행
    print(car1)
    print(car2)
    print("출차" if car1.is_out() else "주차중")
    print("출차" if car2.is_out() else "주차중")

    # 바로 실행하면 실행속도로 인해서 주차시간이 판별되지 않는다.
    # timedelta 를 이용해 출차 시간을 임의로 만든다.

    # 예제는 4 이지만 다양한 시간을 더해 출차시간과 입차시간을 다르게 만들어본다.
    car1.intime -= datetime.timedelta(hours=2) # 입차시간 조정은 2 가 아닌 본인이 직접 정할 것
    car2.outtime += datetime.timedelta(hours=4) # 출차시간 조정은 4 가 아닌 본인이 직접 정할 것
    
    # 주차요금을 계산한다.
    # 시간당 1500 원으로 현재 주차요금을 계산해서 출력한다.
    print("주차요금:" + str(car1.cal_price(1500)))
    print("주차요금:" + str(car2.cal_price(1500)))