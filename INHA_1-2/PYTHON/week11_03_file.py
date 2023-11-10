import os
filePath = "/Users/gangchanhwi/Desktop/INHA/INHA_1-2/python_test/test01.txt"

if os.path.exists("/Users/gangchanhwi/Desktop/INHA/INHA_1-2/python_test"):
    file = open(filePath, "r")

    # 1
    '''while True:
        line = file.readline().strip()
        if not line:
            break
        print(line)'''
    # 2
    '''lines = file.readlines()
    print(lines)
    lines = [i.strip() for i in lines]
    print(lines)'''
    # 3
    datas = file.read()
    print(datas)
    file.close()