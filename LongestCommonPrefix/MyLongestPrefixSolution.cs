namespace LongestCommonPrefix
{
    public class MyLongestPrefixSolution
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
                } else
                {
                    return longestPrefix;
                }
                

            }
            return longestPrefix;

        }
    }
}