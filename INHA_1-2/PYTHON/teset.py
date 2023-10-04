sample = {"key1" : "val1", "key2" : "val2"}

print(sample)
print("-"*50)

a, b = sample.items()
print(a, b)
print("-"*50)

a = sample.keys()
b = sample.values()
print(f"{sample.keys()},\n{b}")
print("-"*50)
print("-"*50)
