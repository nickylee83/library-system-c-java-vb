import java.io.*;
public class libra
{
static BufferedReader input = new BufferedReader(new InputStreamReader(System.in));

static String mid[ ] = new String [9999];
static String name[ ] = new String[9999];
static String ic_no[ ] = new String[9999];
static char gender[ ] = new char[9999];
static String phone[ ] = new String[9999];
static String addr[ ] = new String[9999];
static String reg_date[ ] = new String[9999];
static String exp_date[ ] = new String[9999];

static int counter = 0;

public static void read_member( )throws Exception 
{
	RandomAccessFile data = new RandomAccessFile("library.dat","rw");
	counter = data.readInt( );

	for(int x=0; x < counter; x++)
	{
		mid[x] = data.readUTF( );
		name[x] = data.readUTF( );
		ic_no[x] = data.readUTF( );
		gender[x] = data.readChar( );
		phone[x] = data.readUTF( );
		addr[x] = data.readUTF( );
		reg_date[x] = data.readUTF( );
		exp_date[x] = data.readUTF( );
	};
	data.close( );
};

public static void write_to_file( )throws Exception 
{
	RandomAccessFile data = new RandomAccessFile("library.dat","rw");
	data.writeInt(counter);

	for(int x=0; x < counter; x++)
	{
		data.writeUTF(mid[x]);
		data.writeUTF(name[x]);
		data.writeUTF(ic_no[x]);
		data.writeChar(gender[x]);
		data.writeUTF(phone[x]);
		data.writeUTF(addr[x]);
		data.writeUTF(reg_date[x]);
		data.writeUTF(exp_date[x]);
	};
	data.close( );
};

public static void welcome( ) 
{
	System.out.println("\n\n\t\tWelcome to Library Membership Control System");
	System.out.println("\t\t********************************************");
}


public static void main(String[]args) throws Exception 
{
	read_member();
	welcome();
	
	int count=1;
	do{
		System.out.println("Please Enter User Name ");
		String username = input.readLine();
		System.out.println("Please Enter Password ");
		String password = input.readLine();

		if(username.equals("nicky") && password.equals("octopus"))
		{
			show_menu( );
			count=4;					
		}

		else
			System.out.println("Invalid Login !!!");
				
		count++;

	}while(count<=3);

	write_to_file();		
}

public static void show_menu() throws Exception 
{
	int choice = 0;

	do{
		System.out.println("\n\n\t\t      Library Membership Control System");
		System.out.println("\t\t      *********************************\n\n\n");
		System.out.println("\t\t\t  1. Add New Member");
		System.out.println("\t\t\t  2. Display Member Details");
		System.out.println("\t\t\t  3. Search Member Details");
		System.out.println("\t\t\t  4. Update Member Details");
		System.out.println("\t\t\t  5. Delete Member From System");
		System.out.println("\t\t\t  6. Exit From The System");
		System.out.println("\n\t\t\t  Please Enter A Choice : ");

		choice = Integer.parseInt(input.readLine());

		switch(choice)
		{
			case 1: add_member( );
			break;
			case 2: display_member( );
			break;
			case 3: search_member( );
			break;
			case 4: update_member( );
			break;
			case 5:	delete_member( );
			break;
			
		};
	}while(choice != 6);
}

public static void add_member( ) throws Exception 
{
	for(int x = 0;x < counter; x++)
	{
		do{
			System.out.println("Please Enter Member ID ");
			mid[counter] = input.readLine();		

			if(mid[counter].equals(mid[x]) || mid[counter].length() !=4)
			{
				System.out.println("Invalid ID !!!");			
			};	

		}while(mid[counter].equals(mid[x]) || mid[counter].length() !=4);
	};

	
	
	do{
		System.out.println("Please Enter Name ");
		name[counter] = input.readLine( );

		if(name[counter].length() > 40)
			System.out.println("Name must not have more than 40 characters");

	}while(name[counter].length() > 40);
		
	do{		
		System.out.println("Please Enter IC No. ");
		ic_no[counter] = input.readLine( );

		if(ic_no[counter].length() != 9)
			System.out.println("IC No. must have 9 characters only");

	}while(ic_no[counter].length() != 9);		
			
	System.out.println("Please Enter Gender(M/F) ");
	gender[counter] = Character.toUpperCase((char)System.in.read( ));
	System.in.read();System.in.read();

	do{
		System.out.println("Please Enter Phone No. ");
		phone[counter] = input.readLine( );
		
		if(phone[counter].length() != 8)
			System.out.println("Phone No. must have 8 characters only");

	}while(phone[counter].length() != 8);

	do{
		System.out.println("Please Enter Address ");
		addr[counter] = input.readLine( );
		
		if(addr[counter].length() > 60)
			System.out.println("Address must not have more than 60 characters");

	}while(addr[counter].length() > 60);

	do{
		System.out.println("Please Enter Registration Date(DD/MM/YY) ");
		reg_date[counter] = input.readLine( );
		
		if(reg_date[counter].length() != 8 || reg_date[counter].indexOf("/") ==-1)
			System.out.println("Registration Date must meet this format(DD/MM/YY)");

	}while(reg_date[counter].length() != 8 || reg_date[counter].indexOf("/") ==-1);

	do{
		System.out.println("Please Enter Expiry Date(DD/MM/YY) ");
		exp_date[counter] = input.readLine( );
		
		if(exp_date[counter].length() != 8 || exp_date[counter].indexOf("/") ==-1)
			System.out.println("Expiry Date must meet this format(DD/MM/YY)");

	}while(exp_date[counter].length() != 8 || exp_date[counter].indexOf("/") ==-1);

	counter++;	
}

public static void display_member( )
{
	for(int x = 0; x < counter; x++)
	{
		System.out.println("\nMember ID " + mid[x]);
		System.out.println("Name " + name[x]);
		System.out.println("IC No. " + ic_no[x]);
		System.out.println("Gender " + gender[x]);
		System.out.println("Phone " + phone[x]);
		System.out.println("Address " + addr[x]);
		System.out.println("Registration Date " + reg_date[x]);
		System.out.println("Expiry Date " + exp_date[x]);
	};
}

public static void search_member( ) throws Exception              
{
	String temp_id;
	boolean found = false;

	System.out.println("Enter Member ID to be searched ");
	temp_id = input.readLine( );

	for(int x = 0; x < counter; x++)
	{
		if (temp_id.equals(mid[x]))
		{
			found = true;

			System.out.println("Member ID " + mid[x]);
			System.out.println("Name " + name[x]);
			System.out.println("IC No. " + ic_no[x]);
			System.out.println("Gender " + gender[x]);
			System.out.println("Phone " + phone[x]);
			System.out.println("Address " + addr[x]);
			System.out.println("Registration Date " + reg_date[x]);
			System.out.println("Expiry Date " + exp_date[x]);
		};
	};
	if (found == false)
		System.out.println("Requested Member ID Not Found !!! ");
}

public static void delete_member( ) throws Exception   
{
	String temp_id;
	boolean found = false;

	System.out.println("Enter Member ID to be deleted ");
	temp_id = input.readLine( );

	for(int x = 0; x < counter; x++)
	{
		if (temp_id.equals(mid[x]))
		{
			found = true;
			for(int y=x; y < counter;y++)
			{
				mid[y] = mid[y+1];
				name[y] = name[y+1];
				ic_no[y] = ic_no[y+1];
				gender[y] = gender[y+1];
				phone[y] = phone[y+1];
				addr[y] = addr[y+1];
				reg_date[y] = reg_date[y+1];
				exp_date[y] = exp_date[y+1]; 
			};
			counter--;
			System.out.println("The record has been deleted successfully !!!");
		};
	};
	if (found == false)
		System.out.println("Requested Member ID Not Found !!! ");
}

public static void update_member( ) throws Exception 
{
	String temp_id;
	boolean found = false;

	System.out.println("Enter Member ID to be updated ");
	temp_id = input.readLine( );

	for(int x = 0; x < counter; x++)
	{
		if (temp_id.equals(mid[x]))
		{
			found = true;
			
			System.out.println("Please Enter New Name ");
			String new_name = input.readLine( );

			if(new_name.length() > 40)
				System.out.println("Name must not have more than 40 characters");
			
			name[x] = new_name;
			System.out.println("New Name is " + name[x]);

			System.out.println("Please Enter New IC No. ");
			String new_ic_no = input.readLine( );

			if(new_ic_no.length() !=9)
				System.out.println("IC No. must have 9 characters only");

			ic_no[x] = new_ic_no;
			System.out.println("New IC No. is " + ic_no[x]);

			System.out.println("Please Enter New Gender(M/F) ");
			char new_gender = Character.toUpperCase((char)System.in.read());
			System.in.read();System.in.read(); 			

			gender[x] = new_gender;
			System.out.println("New Gender is " + gender[x]);

			System.out.println("Please Enter New Phone No. ");
			String new_phone = input.readLine( );

			if(new_phone.length() !=8)
				System.out.println("Phone No. must have 8 characters only");			

			phone[x] = new_phone;
			System.out.println("New Phone No. is " + phone[x]);

			System.out.println("Please Enter New Address ");
			String new_addr = input.readLine( );

			if(new_addr.length() >60)
				System.out.println("Address must not have more than 60 characters");

			addr[x] = new_addr;
			System.out.println("New Address is " + addr[x]);

			System.out.println("Please Enter New Registration Date(DD/MM/YY) ");
			String new_reg_date = input.readLine( );

			if(new_reg_date.length() !=8 || new_reg_date.indexOf("/") ==-1)
				System.out.println("Registration Date must meet this format(DD/MM/YY)");
			
			reg_date[x] = new_reg_date;
			System.out.println("New Registration Date is " + reg_date[x]);

			System.out.println("Please Enter New Expiry Date(DD/MM/YY) ");
			String new_exp_date = input.readLine( );

			if(new_exp_date.length() !=8 || new_exp_date.indexOf("/") ==-1)
				System.out.println("Expiry Date must meet this format(DD/MM/YY)");

			exp_date[x] = new_exp_date;
			System.out.println("New Expiry Date is " + exp_date[x]);				
		};
	};

	if (found == false)
		System.out.println("Requested Member ID Not Found !!! ");
}

}