using System;
class CipherComp
{
    public void Encrypt()
    {
        Console.WriteLine("Enter the string");
        string ptxt = Console.ReadLine(), str = "";
        try
        {
            for (int i = 0; i < ptxt.Length; i++)
            {
                char ch = ptxt[i], mx;
                if (char.IsLetter(ch) & char.IsLower(ch))
                {
                    int lg = 219 - ch;
                    mx = (char)lg;
                    str += mx;
                }
                else if (char.IsLetter(ch) & char.IsUpper(ch))
                {
                    int ug = 155 - ch;
                    mx = (char)ug;
                    str += mx;
                }
                else
                {
                    str += ch;
                }
            }
            Console.WriteLine("The encrypted statement is " + str);
            Console.WriteLine("========================================================================");
        }
        catch { Console.WriteLine("Error"); }
    }
}
class MainProg
{
    public static void Main()
    {
        Console.WriteLine("Atbash Cipher Command Line");
        CipherComp ce = new CipherComp();
        for (; ; )
        {
            ce.Encrypt();
        }
    }
}