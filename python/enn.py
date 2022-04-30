import sys
sys.argv[0]
sys.argv[1]
sys.argv[2]
filename = sys.argv[1]
filename2 = sys.argv[2]
crackmsg=''
#filename3 = sys.argv[4]
#key2 = int(sys.argv[5])
print("Press e to Encrypt")
print("Press d to Decrypt")
print("Press c to Crack")
answer=input("Enter Choice:")
if answer=='e':
	newMessage=''
	with open(filename,"r") as f:
   	 data = f.read()
   	 print("Value to be Encrypted:	",data)
   	 key=int(input("Enter key:"))
	message=data
	for  character in message:
		position=ord(character)
		if position==32:
			newposition=32
		else:
			newposition=(position+key)
			if position<91 and newposition >90:
				newposition-=26
			elif position<123 and newposition >122:
				newposition-=26
		newcharacter=chr(newposition)
		newMessage+=newcharacter
	print ("Cypher Value:		", newMessage)
	f.close()
	with open(filename2,"w") as f2:
   	 data = f2.write(newMessage)
	f2.close()

elif answer=='d':
#decrypt
	newMessage=''
	with open(filename) as f:
   	 data = f.read()
   	 print("To Be Decrypted:	",data)
   	 key=int(input("Enter key:"))
	message=data
	for  character in message:
		position=ord(character)
		if position==32:
			newposition=32
		else:
			newposition=(position-key)
			if position>64 and newposition<65:
				newposition+=26
			elif position>96 and newposition<97:
				newposition+=26
		newcharacter=chr(newposition)
		newMessage+=newcharacter
	print ("Decrypted:		",newMessage)
	f.close()

	with open(filename2,"w") as f3:
   	 data = f3.write(newMessage)
	f3.close()
else:
	for i in range(0, 25 + 1):
		newMessage=''
		with open(filename) as f:
			data = f.read()
   #	 print("To Be Crack:	",data)
		message=data
		for  character in message:
			position=ord(character)
			if position==32:
				newposition=32
			else:
				newposition=(position-i)
				if position>64 and newposition<65:
					newposition+=26
				elif position>96 and newposition<97:
					newposition+=26
			newcharacter=chr(newposition)
			newMessage+=newcharacter
		print ("crack:		",i,newMessage)
		c=str(i)
		crackmsg+=' '+c+ ' '+newMessage + chr(10)
		f.close()
	with open(filename2,"w") as f3:
		data = f3.write(crackmsg)
	f3.close()
	
