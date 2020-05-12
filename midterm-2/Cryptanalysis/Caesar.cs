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

        int l = msg.Length;
        string res = ""; 
        char k;
        for (int i = 0; i < l; i++)
        {
            k = Tools.RotChar(msg[i], code);
            res = res + k;
        }

        return res;
    }

    public string Decrypt(string cypherText)
    {
        int l = cypherText.Length;
        string res = ""; 
        char k;
        for (int i = 0; i < l; i++)
        {
            k = Tools.RotChar(cypherText[i], -code);
            res = res + k;
        }

        return res;
    }
    
    public static int GuessKey(string cypherText)
    {
        int[] list = Tools.Histogram(cypherText);
        int l = list.Length;
        int max = 0;
        int pos = 0;
        for (int i = 0; i < l; i++)
        {
            if (max < list[i])
            {
                max = list[i];
                pos = i;
            }
        }

        int key = pos - 4;
        return key;
    }
}
}