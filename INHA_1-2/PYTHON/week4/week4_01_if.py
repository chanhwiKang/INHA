reg_num = input("주민등록번호:")
gen_num = int(reg_num[6])
number = [1, 3, 5, 7]
if range(0, 8):
    if gen_num % 2 :
        print("남자")
    else :
        print("여자")

if gen_num in number :
    print("남자")
else :
    print("여자")

if reg_num[6] in "1,3,5,7" :
    print("남자")
else :
    print("여자")