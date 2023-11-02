import datetime

# 학번:
# 이름:

menu = """======================
1. 입력(수입/지출)
2. 일별 현황
3. 달별 현황
4. 연별 현황
5. 종료
======================"""

housekeepingbook = dict()
housekeepingbook[2018] = list()
housekeepingbook[2018].append(
    {"m": 10, "d": 5, "type": "1", "money": 2000000, "content": "월급"}
)
housekeepingbook[2018].append(
    {"m": 10, "d": 15, "type": "2", "money": 340000, "content": "카드"}
)
housekeepingbook[2018].append(
    {"m": 11, "d": 5, "type": "1", "money": 2000000, "content": "월급"}
)
housekeepingbook[2018].append(
    {"m": 11, "d": 15, "type": "2", "money": 77000, "content": "카드"}
)
housekeepingbook[2018].append(
    {"m": 12, "d": 5, "type": "1", "money": 2200000, "content": "월급"}
)
housekeepingbook[2018].append(
    {"m": 12, "d": 15, "type": "2", "money": 450000, "content": "카드"}
)
housekeepingbook[2018].append(
    {"m": 12, "d": 17, "type": "2", "money": 35000, "content": "통신비"}
)

now = datetime.datetime.now()  # 오늘 날짜시간
year = now.year  # 오늘 연도
month = now.month  # 오늘 월
day = now.day  # 오늘 일


def register(reg_type):
    if temp == "1" or temp == "2":
        money = int(input("금액:"))
        content = input("내역:")
        item = {"m": month, "d": day, "type": temp, "money": money, "content": content}
        if not housekeepingbook.get(year):
            housekeepingbook[year] = list()
        housekeepingbook[year].append(item)


def searchDay(ymd):
    ymd = ymd.split(" ")
    if len(ymd) == 3:
        y = int(ymd[0])
        m = int(ymd[1])
        d = int(ymd[2])

        if housekeepingbook.get(y):
            print("내역 / 수입 / 지출")
            for data in housekeepingbook[y]:
                if data["m"] == m and data["d"] == d:
                    moneys = (
                        (data["money"], "    ")
                        if data["type"] == "1"
                        else ("    ", data["money"])
                    )
                    print(data["content"], "/", moneys[0], "/", moneys[1])
        else:
            print("검색할 데이터가 없습니다.")


def searchMonth(ym):
    ym = ym.split(" ")
    if len(ym) == 2:
        y = int(ym[0])
        m = int(ym[1])

        if housekeepingbook.get(y):
            if len(housekeepingbook[y]):
                incom = {"money": 0, "count": 0}
                outcom = {"money": 0, "count": 0}

                for data in housekeepingbook[y]:
                    if data["m"] == m:
                        if data["type"] == "1":
                            incom["count"] += 1
                            incom["money"] += data["money"]
                        else:
                            outcom["count"] += 1
                            outcom["money"] += data["money"]

                print("수입 : 총 {0}건 {1}원", incom["count"], incom["money"])
                print("지출 : 총 {0}건 {1}원", outcom["count"], outcom["money"])

            else:
                print("검색할 데이터가 없습니다.")
        else:
            print("검색할 데이터가 없습니다.")


def searchYear(y):
    y = int(y)
    if housekeepingbook.get(y):
        in_money = list(
            set([data["money"] for data in housekeepingbook[y] if data["type"] == "1"])
        )
        out_money = list(
            set([data["money"] for data in housekeepingbook[y] if data["type"] != "1"])
        )

        if 0 < len(in_money):
            print(
                "수입 건수 중 : 최저 금액은 {0}원 / 최고 금액 {1}원".format(
                    min(in_money), max(in_money)
                )
            )

        if 0 < len(out_money):
            print(
                "지출 건수 중 : 최저 금액은 {0}원 / 최고 금액 {1}원".format(
                    min(out_money), max(out_money)
                )
            )
    else:
        print("검색할 데이터가 없습니다.")


while True:
    print(menu)
    temp = input(">> ")

    if temp == "":
        continue

    selNo = int(temp)

    if selNo == 1:
        temp = input("수입(1) 지출(2) 선택:")
        if not register(temp):
            print("입력 오류")

    elif selNo == 2:
        temp = input("연 월 일:")
        searchDay(temp)

    elif selNo == 3:
        temp = input("연 월:")
        searchMonth(temp)

    elif selNo == 4:
        temp = input("연:")
        searchYear(temp)

    elif selNo == 5:
        break

print("좋은 하루 되세요")
