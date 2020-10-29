import java.io.*;
public class setup
{

public static void main(String[] args) throws Exception
	{
		RandomAccessFile data = new RandomAccessFile("library.dat","rw");
		data.writeInt(0);
		data.close();
	};
}