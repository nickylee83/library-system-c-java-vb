/* Create Library Membership Control System */

#include<stdio.h>	//declare prototypes
#include<conio.h>
#include<string.h>
#include<ctype.h>
#include<stdlib.h>

void add_mem(void);	//declare functions
void display_mem(void);
void update_mem(void);
void delete_mem(void);
void search_mem(void);
void password(void);

struct			//declare variables in struct
{
	char mem_id[5];
	char name[20];
	char ic_no[10];
	char gender;
	char phone[10];
	char addr[30];
	char reg_date[11];
	char exp_date[11];
}member;

FILE *fptr;		//declare file

void main(void)		//main function
{
	int choice=0;
	password();
	while(choice!=6)
	{
		clrscr();
		gotoxy(24,3);printf("Library Membership Control System");
		gotoxy(24,4);printf("*********************************\n\n\n");
		gotoxy(30,7);printf("1. Add Memeber\n");//construct menu
		gotoxy(30,8);printf("2. Display All Member\n");
		gotoxy(30,9);printf("3. Search Member\n");
		gotoxy(30,10);printf("4. Update Member\n");
		gotoxy(30,11);printf("5. Delete Member\n");
		gotoxy(30,12);printf("6. Exit\n\n\n");
		gotoxy(26,14);printf("Please enter choice !!! ");
		gotoxy(50,14);scanf("%d",&choice);

		switch(choice)
		{
			case 1: add_mem();
			break;
			case 2: display_mem();
			break;
			case 3: search_mem();
			break;
			case 4: update_mem();
			break;
			case 5: delete_mem();
			break;
			case 6: choice=6;
			break;
			default:
			gotoxy(21,16);printf("Invalid choice ! Press any key to continue...");
			getch();
		}    			//end of switch case
	}       			//end of while loop
}           				//end of main program

void add_mem(void)			//add_member function
{
	char temp_id[5];

	clrscr();
	printf("Enter Member ID ");
	fflush(stdin);
	gets(temp_id);

	if((fptr=fopen("D:library.dat","ab+"))==NULL)		//open file
	{
		fprintf(stderr,"Cannot open output file.\n");
		getch();
	}

	fseek(fptr,SEEK_SET,0);
	fread(&member,sizeof(member),1,fptr);

	while(!feof(fptr))
	{
		while(strcmp(member.mem_id,temp_id)==0)
		{
			printf("Duplicate ID !!!");
			printf("\nPlease enter a unique ID");
			getch();

			clrscr();
			printf("Enter Member ID ");
			fflush(stdin);
			gets(temp_id);
		}
		fread(&member,sizeof(member),1,fptr);
	}

	strcpy(member.mem_id,temp_id);
	fclose(fptr);

	printf("Enter Name ");
	fflush(stdin);
	gets(member.name);


   do{
		printf("Enter IC no: ");
		fflush(stdin);
		gets(member.ic_no);

		if(strlen(member.ic_no)!=9)
		{
			printf("IC No. must have 9 characters only.\n");
		}

	}while(strlen(member.ic_no)!=9);


	printf("Enter gender(M/F) ");
	scanf("%c",&member.gender);
	member.gender=toupper(member.gender);

	do{
		printf("Enter phone no: ");
		fflush(stdin);
		gets(member.phone);

		if(strlen(member.phone)!=8)
			printf("Phone must have 8 characters only.\n");

   }while(strlen(member.phone)!=8);

	printf("Enter address ");
	fflush(stdin);
	gets(member.addr);

	printf("Enter registration date (DD/MM/YYYY) ");
	fflush(stdin);
	gets(member.reg_date);

	printf("Enter expiry date (DD/MM/YYYY) ");
	fflush(stdin);
	gets(member.exp_date);

	if((fptr=fopen("D:library.dat","ab+"))==NULL)		//open file
	{
		fprintf(stderr,"Cannot open output file.\n");
		getch();
	}

	fwrite(&member,sizeof(member),1,fptr);			//write to file
	fclose(fptr);						//close file

	printf("Record has been successfully added.");
	getch();
}

void display_mem(void)					//display member function
{
	clrscr();
	if((fptr=fopen("D:library.dat","rb+"))==NULL)	//open file
	{
		fprintf(stderr,"Cannot open output file.\n");
		getch();
		//	exit(0);
	}

	fseek(fptr,SEEK_SET,0);				//set pointer to position 0
	fread(&member,sizeof(member),1,fptr);		//read record

	if(feof(fptr))
	{
		gotoxy(30,2);
		printf("No record in Member Database");
		getch();
	}

	while(!feof(fptr))				//while not end of file
	{
		printf("Member ID:  %s\n",member.mem_id);
		printf("Name: %s\n",member.name);
		printf("IC No: %s\n",member.ic_no);
		printf("Gender: %c\n",member.gender);
		printf("Phone: %s\n",member.phone);
		printf("Address: %s\n",member.addr);
		printf("Registration Date: %s\n",member.reg_date);
		printf("Expiry Date: %s\n \n",member.exp_date);

		fread(&member,sizeof(member),1,fptr);	//read record
	}
	fclose(fptr);					//close file
	getch();
}

void search_mem(void)					//search record
{
	char temp_id[5];

	clrscr();
	printf("Enter Member ID to be searched ");	//prompt to accept ID to search
	fflush(stdin);
	gets(temp_id);

	if((fptr=fopen("D:library.dat","rb+"))==NULL)	//open file
	{
		fprintf(stderr,"Cannot open output file\n");
		getch();
	}

	fseek(fptr,SEEK_SET,0);				//set pointer to position 0
	fread(&member,sizeof(member),1,fptr);		//read record

	if(feof(fptr))
	{
		gotoxy(30,2);
		printf("No record in Member Database");
		getch();
	}

	while(!feof(fptr))				//while not end of file
	{
		if(strcmp(temp_id,member.mem_id)==0)	//compare 2 IDs and show record if found
		{
			printf("Name: %s \n",member.name);
			printf("IC No: %s \n",member.ic_no);
			printf("Gender: %c \n",member.gender);
			printf("Phone: %s \n",member.phone);
			printf("Address: %s \n",member.addr);
			printf("Registration Date: %s \n",member.reg_date);
			printf("Expiry Date: %s \n",member.exp_date);
		}
		fread(&member,sizeof(member),1,fptr);		//read record
	}
	fclose(fptr);						//close file
	getch();
}

void update_mem(void)						//update record
{
	char temp_id[5];
	int filepos;

	clrscr();
	printf("Enter Member ID to be updated ");	//prompt user to accept ID to search
	fflush(stdin);
	gets(temp_id);

	if((fptr=fopen("D:library.dat","rb+"))==NULL)		//open file
	{
		fprintf(stderr,"Cannot open output file\n");
		getch();
	}

	fseek(fptr,SEEK_SET,0);					//set pointer to position 0
	fread(&member,sizeof(member),1,fptr);			//read record

	if(feof(fptr))
	{
		gotoxy(30,2);
		printf("No record in Member Database");
		getch();
	}

	while(!feof(fptr))					//while not end of file
	{
		if(strcmp(temp_id,member.mem_id)==0)  //compare 2 IDs and if it's found
		{

			printf("Enter new Name ");		//accept new values
			fflush(stdin);
			gets(member.name);

			do{
				if(strlen(member.ic_no)!=9)
				{
					printf("Enter new IC no: ");
					fflush(stdin);
					gets(member.ic_no);

					printf("\nIC No. must be 9 characters only\n");
				}

			}while(strlen(member.ic_no)!=9);

			printf("Enter new Gender(M/F) ");
			scanf("%c",&member.gender);
			member.gender=toupper(member.gender);

			do{
				if(strlen(member.phone)!=8)
				{
					printf("Enter new phone no: ");
					fflush(stdin);
					gets(member.phone);

					printf("\nPhone must be 8 characters only\n");
				}
			}while(strlen(member.phone)!=8);

			printf("Enter new address ");
			fflush(stdin);
			gets(member.addr);

			printf("Enter new registration date (DD/MM/YYYY) ");
			fflush(stdin);
			gets(member.reg_date);

			printf("Enter new expiry date (DD/MM/YYYY) ");
			fflush(stdin);
			gets(member.exp_date);

			filepos=ftell(fptr)-sizeof(member);
			fseek(fptr,filepos,0);

			fwrite(&member,sizeof(member),1,fptr);
			fclose(fptr);

			printf("Record is updated successfully.");
		}
		fread(&member,sizeof(member),1,fptr);			//read record
	}
	fclose(fptr);							//close file
	getch();
}

void delete_mem(void)							//delete record
{
	FILE *temp;
	char confirm;
	char tempname[80]="D:temp.dat",existingname[80]="D:library.dat";
	int check;
	char del_id[5];

	clrscr();

	if((fptr=fopen("D:library.dat","rb+"))==NULL)  //open existing file in read mode
	{
		printf("Cannot open input file.");
		getch();
	}

	check=0;
	clrscr();
	printf("Please enter Member ID to be deleted! ");		//prompt user the ID to be deleted
	fflush(stdin);
	gets(del_id);

	if((temp=fopen("D:temp.dat","wb+"))==NULL)			//open temp file in write mode
	{
		printf("Cannot open temporary file.");
		getch();
	}

	fseek(fptr,SEEK_SET,0);						//set pointer posistion to 0
	fread(&member,sizeof(member),1,fptr);				//read from existing file

	while(!feof(fptr))						//while not end of file
	{
		if(strcmp(del_id,member.mem_id)==0)			//compare 2 IDs and if it's found
			check=1;
		else							//if the ID is not found
		{
			fwrite(&member,sizeof(member),1,temp);		//write to temp file
		}

		fread(&member,sizeof(member),1,fptr);	//read from existing file
	}
	fclose(fptr);							//close existing file
	fclose(temp);							//close temp file

	if(check!=1)
	{
		clrscr();
		printf("Unable to find the Member ID %s",del_id);	//if ID is not found show Not found
		getch();
	}
	else
	{
		clrscr();						//else ask for confirmation
		printf("Are you sure you want to delete[Y/N] ?");
		fflush(stdin);
		scanf("%c",&confirm);

		if(toupper(confirm)=='Y')				//if confirm, remove existing file and
		{
			remove(existingname);
			rename(tempname,existingname);			//rename temp file to existing file name
			printf("Record is successfully deleted!");
			getch();
		}
	}
	remove(tempname);						//remove temp file
}

void password(void)
{
	int i=0;
	char pass[8]="octopus";
	char tmp[8];

	clrscr();
	printf("\n \nWelcome to Library Membership Control System\n");
	printf("---------------------------------------------\n\n\n");
	printf("System Login\n \n");
	while(i<3)
	{
		printf("Enter password  ");
		fflush(stdin);
		gets(tmp);

		if(strcmp(tmp,pass)==0)
		{
			printf("Login successful !");
			getch();
			break;
		}
		else
		{
			printf("\nLogin failed !\n\n");
			getch();
		}
		i++;
	}
	if(i==3)
	{
		printf("\nMaximum try limits reached  !");
		printf("\n\nSystem will be shut down !!!");
		getch();
		exit(0);
	}
}