using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            string[] strs=new string[]{};
            Solution solu=new Solution();
            string result=solu.LongestCommonPrefix(strs);
            Console.WriteLine("Longest string: {0}", result);
        }
    }
    
    public class Solution {
        public string LongestCommonPrefix(string[] strs) {
            List<char> commonPrefix=new List<char>();
            List<int> stringLength=new List<int>();
            string comprefix="";
            
            try
            {
                //count the longest string
                foreach(var str in strs)
                {
                    stringLength.Add(str.Length);
                }
                int longestStringLength=stringLength.Min();
                
                //compare string commonprefix
                for(var i=0;i<longestStringLength;i++)
                {
                    int counter=0;
                    char current=strs[0][i];
                    
                    for(var j=0;j<strs.Length;j++)
                    {
                        if(current==strs[j][i])
                        {
                            counter++;
                        }else
                        {
                            comprefix=string.Join("", commonPrefix.ToArray());
                            return comprefix;
                        }
                    }
                    if(counter==strs.Length)
                    {
                        commonPrefix.Add(current);
                    }
                }
                comprefix=string.Join("", commonPrefix.ToArray());
                return comprefix;
            }
            catch(InvalidOperationException)
            {
                return "";
            }
        }
    }
}
