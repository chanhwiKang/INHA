def standard_weight(height, sex):
    height_int = int(height*100)
    if sex == "m":
        print(f"키 {height_int}cm의 남자의 표준 체중은 {round(height * height * 22, 2)}입니다.")
    else:
        print(f"키 {height_int}cm의 여지의 표준 체중은 {round(height * height * 21, 2)}입니다.")

standard_weight(1.75, "m")