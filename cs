name = input("Enter your name: ")
  Enter your name: Kaiser
num1 = int(input("Enter 1st number: "))
     Enter 1st number: 15
num2 = int(input("Enter 2nd number: "))
     Enter 2nd number: 67
num3 = int(input("Enter 3rd number: "))
     Enter 3rd number: 54
print("Hello, ", name)
     Hello,  BlueLock
#compare the numbers
     
if (num1 >= num2) and (num1 >= num3):
    print("The biggest number is", num1)
elif (num2 >= num1) and (num2 >= num3):
    print("The biggest number is", num2)
elif (num3 >= num1) and (num3 >= num2):
    print("The biggest number is", num3)
else:
    print(num1, num2, "and", num3, "are equal")
     The biggest number is 67
