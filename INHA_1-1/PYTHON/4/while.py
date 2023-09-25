# customer = "tor"
# index = 5
# while index >= 1:
#     print(f"{customer}님, 커피가 준비되었어요. {index}번 남았어요.")
#     index -= 1
#     if index == 0:
#         print("폐기 처분 되었습니다.")

#customer = "ironman"
#index = 1
# while True:
#     print(f"{customer}님, 커피가 준비되었어요. 호출{index}회.")
#     index += 1

customer = "tor"
person = "unknown"

while person != customer :
    print(f"{customer}, 커피가 준비 되었습니다.")
    person = input("이름이 뭐세요?")