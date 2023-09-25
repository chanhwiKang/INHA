#wehater = input("오늘 날씨는? ")
#if wehater == "rain" or :
#    print("umb")
#elif wehater == "sun":
#    print("sunny")
#else:
#    print("no rain, no sun")

temp = int(input("오늘 몇도? ")) # input함수는 문자열로 받기때문에, int()로 감싸 정수형으로 만든다.
if 30 <= temp:
    print("too hot")
elif 10 <= temp < 30: # 10 <= temp and temp < 30:
    print("nice temp")
elif 0 <= temp < 10:
    print("take clothes")
else:
    print("too cold")