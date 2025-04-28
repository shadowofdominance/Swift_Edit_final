// === File: SearchHelper.cs ===
using System;
using System.Collections.Generic;

public static class SearchHelper
{
    public static int KMPSearch(string text, string pattern, int startIndex)
    {
        if (string.IsNullOrEmpty(pattern)) return -1;

        int[] lps = BuildLPSArray(pattern);
        int i = startIndex, j = 0;

        while (i < text.Length)
        {
            if (pattern[j] == text[i])
            {
                i++;
                j++;
            }

            if (j == pattern.Length)
            {
                return i - j;
            }
            else if (i < text.Length && pattern[j] != text[i])
            {
                if (j != 0)
                    j = lps[j - 1];
                else
                    i++;
            }
        }
        return -1;
    }

    private static int[] BuildLPSArray(string pattern)
    {
        int[] lps = new int[pattern.Length];
        int length = 0, i = 1;

        while (i < pattern.Length)
        {
            if (pattern[i] == pattern[length])
            {
                length++;
                lps[i] = length;
                i++;
            }
            else
            {
                if (length != 0)
                {
                    length = lps[length - 1];
                }
                else
                {
                    lps[i] = 0;
                    i++;
                }
            }
        }
        return lps;
    }
}
