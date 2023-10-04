while True :
    user_input = input("입력:")
    if "안녕" in user_input :
        print("안녕하세요")
    elif "몇 시" in user_input :
        print("15시")
    else :
        print(user_input)
        break