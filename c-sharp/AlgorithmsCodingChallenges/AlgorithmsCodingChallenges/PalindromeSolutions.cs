namespace AlgorithmsCodingChallenges;
    public class PalindromeSolutions
    {
        public bool IsPalindrome(int number)
        {
            var stringNumber = number.ToString();

            for (int i = 0; i < stringNumber.Length/2; i++)
            {
                if(stringNumber[i] != stringNumber[stringNumber.Length-1-i])
                {
                    return false;
                }
            }

            return true;
        }
        
    }
