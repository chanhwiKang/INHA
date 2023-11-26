import practice1 as model

print(model.PI)

a = model.Math()
print(a.solv(2))
print(model.add(model.PI, 4.4))

print("="*30)

from datetime import datetime as dt
d = dt.now()
print(d.year, d.month, d.day)
print(d.hour, d.hour, d.minute, d.second, d.microsecond)
print(d.weekday(), d.date(), d.time())

print("="*30)

d1 = dt.now()
d2 = dt.strftime(d1, "%d-%m-%Y %H:%M:%S")
d3 = dt.strptime(d2, "%d-%m-%Y %H:%M:%S")
print(type(d1), d1)
print(type(d2), d2)
print(type(d3), d3)