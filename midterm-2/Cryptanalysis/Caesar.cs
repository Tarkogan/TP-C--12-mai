using System;

namespace Cryptanalysis
{
public class Caesar
{
    private int code;

    public int Code
    {
        get => code;
    }

    public Caesar(int key)
    {
        code = key;
    }

    public string Encrypt(string msg)
    {
        Caesar simple = new Caesar(code);
        
        int l = msg.Length;
        string res = "";
        for (int i = 0; i < l; i++)
        {
            //res[i] = Tools.RotChar(msg[i], code);
        }

        return res;
    }

    public string Decrypt(string cypherText)
    {
        Caesar simple = new Caesar(code);
        return "";
    }
    
    public static int GuessKey(string cypherText)
    {
        throw new NotImplementedException();
    }
}
}