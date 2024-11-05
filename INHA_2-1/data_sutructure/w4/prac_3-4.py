def add_data(data):
    datas.append(None)
    d_len = len(datas)
    datas[d_len-1] = data

def insert_data(pos, data):
    if pos < 0 or pos > len(datas):
        print("범위를 벗어납니다.")
        return
    datas.append(None)
    d_len = len(datas)
    for i in range(d_len-1, pos, -1):
        datas[i] = datas[i-1]
        datas[i-1] = None
    datas[pos] = data

def delet_data(pos):
    if pos < 0 or pos > len(datas):
        print("범위를 벗어남")
        return
    datas[pos] = None
    d_len = len(datas)
    for i in range(pos+1, d_len):
        datas[i-1] = datas[i]
        datas[i] = None
    del datas[d_len-1]

datas = []
if __name__ == "__main__":
    while True:
        menu = input("1. 추가, 2. 삽입, 3. 삭제, 4. 종료 --> ")
        if menu == "1":
            data = input("추가할 값 입력")
            add_data(data)
            print(datas)
        elif menu == "2":
            pos = int(input("추가할 위치 입력"))
            data = input("추가할 값 입력")
            insert_data(pos, data)
            print(datas)
        elif menu == "3":
            pos = int(input("추가할 위치 입력"))
            delet_data(pos)
            print(datas)
        elif menu == "4":
            break
        else:
            print("올바른 값 입력좀")