using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    public class MySolutions
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string[] inputWords = strs;

            var wordCount = inputWords.Count();

            // turn first word into char array for comparison
            char[] firstWordToCharArr = inputWords.First().ToCharArray();

            // set up counter for occurences of current prefix in loop
            int commonCount;
            string currentPrefix = "";
            string longestPrefix = "";
            for (var i = 0; i < firstWordToCharArr.Length; i++)
            {

                currentPrefix = currentPrefix + firstWordToCharArr[i].ToString();
                commonCount = 0; // reset to 0 for each prefix
                foreach (var word in inputWords)
                {
                    if (word.StartsWith(currentPrefix))
                    {
                        commonCount++;
                    }
                }
                // find instances in each word
                if (commonCount == wordCount)
                {
                    //if currentPrefix is in all words, store current value and continue
                    longestPrefix = currentPrefix;
                    continue;
                }
                else
                {
                    return longestPrefix;
                }


            }
            return longestPrefix;

        }
         public static bool IsPalindrome(int x)
            {
                string numAsString = x.ToString();

                char[] charArr = numAsString.ToCharArray();
                var reversedChar = charArr.Reverse();
                string reversedString = "";
                foreach (var num in reversedChar)
                {
                    reversedString += num.ToString();
                }
                bool xIsPalindrome = reversedString == numAsString;
                return xIsPalindrome;
            }
        

        public static int RomanToInt(string s)
        {
            Dictionary<string, int> romNumDictionary = new Dictionary<string, int>();

            romNumDictionary.Add("I", 1);
            romNumDictionary.Add("V", 5);
            romNumDictionary.Add("X", 10);
            romNumDictionary.Add("L", 50);
            romNumDictionary.Add("C", 100);
            romNumDictionary.Add("D", 500);
            romNumDictionary.Add("M", 1000);
            char[] romNumToArray = s.ToCharArray();
            int currentValue = 0;
            for (var i = 0; i < romNumToArray.Length; i++)
            {
                var charValue = romNumDictionary.First(a => a.Key == romNumToArray[i].ToString()).Value;
                try
                {
                    var prevCharValue = romNumDictionary.First(a => a.Key == romNumToArray[i - 1].ToString()).Value;
                    if (charValue > prevCharValue)
                    {
                        currentValue = currentValue + (charValue - prevCharValue) - prevCharValue;
                    }
                    else
                    {
                        currentValue = currentValue + charValue;
                    }
                }
                catch (Exception e)
                {
                    currentValue = charValue;
                }


            }
            return currentValue;
        }

        public int[] TwoSum(int[] nums, int target)
        {

            int[] numArray = nums;
            int[] ans = new int[2];
            int t = target;
            int count = 0;
            foreach (int i in numArray)
            {

                for (int j = 0; j < numArray.Length; j++)
                {
                    if ((numArray[j] == i) && (count == j))
                    {
                        break;
                    }
                    if ((numArray[j] + i) == t)
                    {
                        ans = new int[] { count, j };
                        break;

                    }

                }
                count++; continue;
            }
            return ans;
        }
        
        // Valid Parentheses
        public static bool IsValid(string s)
        {
            bool stringIsValid = true;
            string currString = s;
            while (currString.Contains("{}") || currString.Contains("[]") || currString.Contains("()"))
            {
                currString = currString.Replace("{}", "").Replace("[]", "").Replace("()", "");
            }

            if (currString.Length > 0)
            {
                stringIsValid = false;
            }
            return stringIsValid;

        }

        // Merge Two Sorted Lists
        
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode inputList1 = list1;
            ListNode inputList2 = list2;

            var headNode1 = list1.val;
            var nextNode1 = list1.next;

            var headNode2 = list2.val;
            var nextNode2 = list2.next;


        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }


    



}

