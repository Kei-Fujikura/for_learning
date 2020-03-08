import clr

clr.AddReference('sample_dll')
from sample_dll import Class1
from sample_dll import Class2

C1 = Class1()

c = C1.count()
print(c)
c = C1.count()
print(c)
c = C1.count()
print(c)

d = 0
a = C1.out_count(d)
print("a: " + str(a))
print("d: " + str(d))

c2 = Class2()
b = C1.class_input(c2)
print("b: " + str(b))
print("c2: " + str(c2))

