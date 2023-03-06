using System;
using System.IO;
class CopyFile 
{
    static void Main(string[] args)
    {
        int i;
        FileStream fin = null;
        FileStream fout = null;

        if (args.Length != 2)
        {
            System.Console.WriteLine("Simple: CopyFile IN OUT");
            return;
        }

        try
        {
            fin = new FileStream(args[0], FileMode.Open);
            fout = new FileStream(args[1], FileMode.Create);

            //for (char c = 'A'; c <= 'Z'; c++)
            //{
            //    Console.WriteLine($"symbol: {c} = byte: {(byte)c}");
            //    fout.WriteByte((byte)c);
            //}

            do
            {
                i = fin.ReadByte();
                if (i != -1)
                    fout.WriteByte((byte)i);
            }
            while (i != -1);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"error: {ex.Message} path: {args[0]}");
        }
        finally
        {
            if (fout != null) fout.Close();
            if (fin != null) fin.Close();
        }
    }

}