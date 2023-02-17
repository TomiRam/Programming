import random
passlen = int(input("enter the length of password"))
s= "abcdefghijklmnopqrstuvwxy01234567890ABCDEFGHIJKLMNOPQRSTUVWYXZ!@£$$€&*"
p= "".join(random.sample(s,passlen))
print(p)