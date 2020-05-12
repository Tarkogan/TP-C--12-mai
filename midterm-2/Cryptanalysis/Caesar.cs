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
        throw new NotImplementedException();
        int l = msg.Length;
        for (int i = 0; i < l; i++)
        {
            
        }
    }

    public string Decrypt(string cypherText)
    {
        throw new NotImplementedException();
    }
    
    public static int GuessKey(string cypherText)
    {
        throw new NotImplementedException();
    }
}
}