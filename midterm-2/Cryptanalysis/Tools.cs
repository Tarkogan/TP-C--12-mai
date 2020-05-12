using System;

namespace Cryptanalysis
{
public static class Tools
{
    public static int Modulus(int a, int b)
    {
        if (b < 0)
            b = -b;
        
        var mod = a % b;
        return mod < 0 ? b + mod : mod;
    }

    public static int LetterIndex(char c)
    {
        int k = Convert.ToInt32(c);
        int res = -1;
        for (int i  = 0; i  < 26; i ++)
        {
            if (k == (65+i))
            {
                res = i ;
            }

            if (k == (97+i))
            {
                res = i;
            }
        }
        return res;
    }
    
    public static char RotChar(char c, int n)
    {
        int let = LetterIndex(c);
        int min = Convert.ToInt32(c);
        int maj = 0;
        if (96 < min && min< 123)
        { 
            maj = 97;
        }

        if (64 < min&& min < 91)
        {
            maj = 65;
        }
        if (let == -1 || n == 0)
        {
            return c;
        }

       int pos = Modulus((let +n),26);
       char res = Convert.ToChar(pos + maj);
       return res;

    }

    public static int[] Histogram(string str)
    {
        int[] res = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int l = str.Length;
        for (int i = 0; i < l; i++)
        {
            int k = LetterIndex(str[i]);
            if ( k != -1 )
            {
                res[k] += 1;
            }
            
        }
        return res;

    }
    
    public static string FilterLetters(string str)
    {
        throw new NotImplementedException();
    }

    public static string Extract(string str, int start, int step)
    {
        throw new NotImplementedException();
    }
}
}
