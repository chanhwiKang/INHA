from datetime import datetime as dt
import homework1_func as hf

if __name__ == "__main__":
    if len(hf.load_student_info()) == 0:
        print("복원할 파일이 없습니다.")
    else:
        for v in hf.load_student_info():
            print(f"{v}")
    while True:
        selected_menu = hf.select_menu()
        # 학생 정보 추가
        if selected_menu == "1":
            if not hf.get_student_info():
                continue
            else :
                hf.save_student_info()
                
        # 학생 정보 삭제
        elif selected_menu == "2":
            if not hf.del_student_info():
                continue
            else:
                hf.save_student_info()
                
        # 학생 정보 수정
        elif selected_menu == "3":
            if not hf.update_student_info():
                continue
            else:
                hf.save_student_info()
        # 학생 정보 확인
        elif selected_menu == "9":
            for i in hf.student_list:
                print(i)
        # 프로그램 종료
        elif selected_menu == "0":
            hf.save_student_info()
            break

    