import java.util.*;
import java.io.*;
public class Cypher {

	public static void main(String[] args)throws Exception{
	@SuppressWarnings("resource")
	BufferedWriter writer = null;
	BufferedWriter writer2 = null;
	String crackk="";
	String fname="";
	int an=0;
	Scanner input=new Scanner(System.in);
	int a=0;
	int newascii;
	String Test="";
	String Encrypt="";
	String Decrypt="";
 	System.out.println("[1] Encrypt");
 	System.out.println("[2] Decrypt");
 	System.out.println("[3] Crack");
 	an=input.nextInt();
 	if (an==1){
 	System.out.println("Enter Filename");
 	fname=input.next();
    File file = new File(fname);
    @SuppressWarnings("resource")
	BufferedReader br = new BufferedReader(new FileReader(file));
    String st="";
    while((st=br.readLine())!= null){
    Test+=st+(char)10;
    }
    System.out.print(Test);
  //   System.out.println(Test.charAt(1));

 	System.out.print("Enter Key:");
 	a=input.nextInt();
 	
	for (int x=0;x<Test.length();x++){
		int ascii= (int)Test.charAt(x);
		if(ascii==10){
				newascii=ascii;
			}
			else if(ascii==13){
 				newascii=ascii;
 			}
			else if(ascii==32){
				newascii=ascii;
			}
			else{
			newascii=ascii+a;
				if ((ascii<91)&&(newascii>90))
				{
					newascii-=26;
				}
				else if ((ascii<123)&&(newascii>122))
				{
					newascii+=26;
				}
			}
		Encrypt+=(char)newascii;
	
	}
	System.out.println(Encrypt);
    try {
        File logFile = new File("Encrypt.txt");
        System.out.println(logFile.getCanonicalPath());
        writer = new BufferedWriter(new FileWriter(logFile));
        writer.write(Encrypt);
        writer.close();
    } catch (Exception e) {
        e.printStackTrace();
    }
 	}
 	else if(an==2){
    
    File file2 = new File("encrypt.txt");
    BufferedReader br2 = new BufferedReader(new FileReader(file2));
    String st2="";
    Test="";
    while((st2=br2.readLine()) != null){
    Test+=st2+(char)10;
    }
    System.out.print(Test);
	System.out.print("Enter Key:");
	a=input.nextInt();
	
	for (int x=0;x<Test.length();x++){
		int ascii= (int)Test.charAt(x);
		if(ascii==10){
				newascii=ascii;
			}
			else if(ascii==13){
 				newascii=ascii;
 			}
			else if(ascii==32){
				newascii=ascii;
			}
			else{
			newascii=ascii-a;
				if ((ascii>64)&&(newascii<65))
				{
					newascii+=26;
				}
				
				else if ((ascii>96)&&(newascii<97))
				{
					newascii+=26;
				}
			}
		Decrypt+=(char)newascii;
	
	}
	System.out.println(Decrypt);
   try {
       File logFile = new File("Decrypt.txt");
       System.out.println(logFile.getCanonicalPath());
       writer2 = new BufferedWriter(new FileWriter(logFile));
       writer2.write(Decrypt);
       writer2.close();
   } catch (Exception e) {
       e.printStackTrace();
   }
	}
 	else{
	 
 	    File file3 = new File("Encrypt.txt");
 	    BufferedReader br3 = new BufferedReader(new FileReader(file3));
 	    String st3="";
 	    Test="";
 	    while((st3=br3.readLine()) != null){
 	    Test+=st3+(char)10;
 	    }
 	    System.out.print("The Message to crack:"+Test);
 	   for(int key=0;key<26;key++){ 			
 		   
 		   Decrypt="";
 		for (int x=0;x<Test.length();x++){
 			int ascii= (int)Test.charAt(x);
 			if(ascii==10){
 				Decrypt=Decrypt+(char)13+(char)10;
 			}

 			else if(ascii==32){
 				newascii=ascii;
 			}
 			else{
 			newascii=ascii-key;
 				if ((ascii>64)&&(newascii<65))
 				{
 					newascii+=26;
 				}
 				else if ((ascii>96)&&(newascii<97))
 				{
 					newascii+=26;
 				}
 				Decrypt+=(char)newascii;
 			}
 			
 		
 		}
		System.out.print("key:"+key+" value:"+Decrypt);
 		crackk+=key+":"+Decrypt;
}
 		//System.out.print(crackk);
 	   try {
 	       File logFile = new File("Crack.txt");
 	       System.out.println(logFile.getCanonicalPath());
 	       writer2 = new BufferedWriter(new FileWriter(logFile));
 	       writer2.write(crackk);
 	       writer2.close();
 	   } catch (Exception e) {
 	       e.printStackTrace();
 	   }
 		}
 	}
}
	
