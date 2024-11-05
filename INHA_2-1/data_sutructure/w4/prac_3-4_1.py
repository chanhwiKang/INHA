def append_arr(data):
    arr.append(None)
    d_len = len(arr)
    arr[d_len-1] = data

def insert_arr(pos, data):
    arr.append(None)
    d_len = len(arr)
#   arr = ["0", "1", "2", "3", "4", None] 6
    for i in range(d_len-1, pos, -1):
        arr[i] = arr[i-1]
        arr[i-1]= None
    arr[pos] = data

def delete_arr(pos):
    arr[pos] = None
    d_len = len(arr)

    for i in range(pos+1, d_len):
        arr[i-1] = arr[i]
        arr[i] = None
    del arr[d_len-1]

arr = ["0", "1", "2", "3", "4"]
while True:
    menu = input("선택하세요(1: 추가, 2: 삽입, 3: 삭제, 4: 종료)--> ")
    if menu == "1":
        data = input("어떤 값을 넣을까")
        append_arr(data)
    elif menu == "2":
        pos = int(input("몇번째 위치?"))
        data = input("어떤 값을 넣을까")
        insert_arr(pos, data)
    elif menu == "3":
        pos = int(input("삭제할 idx는?"))
        delete_arr(pos)
    print(arr)