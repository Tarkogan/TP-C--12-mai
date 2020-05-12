using System;

namespace Cryptanalysis
{
public class Vigenere
{
    public const float FrenchIndexOfCoincidence = 0.0778F;
    private string code;

    public string Code
    {
        get => code;
    }

    public Vigenere(string key)
    {
        char x;
        if (key == "" )
        {
            throw new ArgumentException("C'est vide");
        }
        int l = key.Length;
        for (int i = 0; i < l; i++)
        {
             int y = Convert.ToInt32(key[i]);
            if (!(96 < y && y < 123) && !(64 < y && y < 91))
            {
                throw new ArgumentException("il y a autre chose que des lettres");
            }

            code = key;
        }
    }

    public string Encrypt(string msg)
    {
        int l = msg.Length;
        int lk = code.Length;
        int w;
        char c;
        string res = "";
        int k = 0;
        for (int i = 0; i < l; i++)
        {
            w = Tools.LetterIndex(code[Tools.Modulus(k,3)]);
            if (Tools.LetterIndex(msg[i]) != -1)
            {
                c = Tools.RotChar(msg[i], w);
                res = res + c;
                k = k + 1;
            }
            else
            {
                res = res + msg[i];
                
            }
        }

        return res;
    }

    public string Decrypt(string cypherText)
    {
        throw new NotImplementedException();
    }

    public static string GuessKeyWithLength(string cypherText, int keyLength)
    {
        throw new NotImplementedException();
    }
    
    public static float IndexOfCoincidence(string str)
    {
        throw new NotImplementedException();
    }

    public static int GuessKeyLength(string cypherText)
    {
        throw new NotImplementedException();
    }
    
    public static string GuessKey(string cypherText)
    {
        throw new NotImplementedException();
    }
}
}
