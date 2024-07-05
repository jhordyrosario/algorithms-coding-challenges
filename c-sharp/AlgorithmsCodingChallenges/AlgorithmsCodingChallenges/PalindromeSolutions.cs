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

        public bool IsPalindrome2(int number)
        {
            if(number < 0)
            {
                return false;
            }

            var inverted = string.Empty;
            var division = number;
            
            while (division != 0)
            {
                int module = division % 10;
                inverted += module; 
                division /= 10;
            }

            return number == int.Parse(inverted);
        }
        
    }
