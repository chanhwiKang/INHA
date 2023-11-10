filePath = "/Users/gangchanhwi/Desktop/INHA/INHA_1-2/python_test/test01.txt"
# file = open(filePath, "w")
file = open(filePath, "a") # 'a'ppend mode

file.write("김인하\n")
file.write("컴퓨터정보\n")
file.write("1학년\n")
file.write("이인하|컴퓨터시스템|2학년\n")
file.close()