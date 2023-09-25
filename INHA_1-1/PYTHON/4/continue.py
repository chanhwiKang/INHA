absent = [2, 5]
no_book = [7]
for  student in range(1, 11):
    if student in absent:
        continue #밑의 문장을 넘기고 반복문 재 진행
    elif student in no_book:
        print(f"오늘 수업 여기까지. {student}는 교무실로 따라와")
        break # 반복문을 끝냄
    print(f"{student}, 책을 읽어줘")
