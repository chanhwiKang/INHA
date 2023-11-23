import datetime
now = datetime.datetime.now() # now = modul_name.class.method()
print(now)
print(now.year)
print(now.month)
print(now.hour)
print(now.minute)
print(now.second)

if now.hour < 12 : print("AM")
else : print("PM")