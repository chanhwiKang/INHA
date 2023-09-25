# import pickle

# with open("profile.pickle", "rb") as profile_file: # profile.pickle을 열어서 profile_file에 저장
#     print(pickle.load(profile_file))

with open("study.txt", "w", encoding="utf8") as study_file:
    study_file.write("python")

with open("study.txt", "r", encoding="utf8") as study_file:
    print(study_file.read())