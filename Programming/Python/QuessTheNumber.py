import random
number = random.randint(1,10)
for i in range(0,3):
	user = int(input("quess the number"))
	if user == number:
		print("Hurray!")
		print(f"you quessed the number right it's {number}")
		break
if user != number:
	print(f"you quess is incorrect the number is {number}")