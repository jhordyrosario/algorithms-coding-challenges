namespace AlgorithmsCodingChallenges;

public class TwoSumSolutions
{
    public int[] TwoSum1(int[] nums, int target) {
        for(var i=0; i<=nums.Length-2 ; i++)
        {
            for(var j=i+1; j<=nums.Length-1; j++)
            {
                if(target-nums[j] == nums[i])
                {
                    return [i,j];
                }     
            }
        }

        throw new Exception("Two Sum Not Found");
    }

    public int[] TwoSum2(int[] nums, int target) {
        
        var valuesIndexes = new Dictionary<int, int>();

        for(var i=0; i<nums.Length ; i++)
        {
            valuesIndexes[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int searchedValue = target - nums[i];

            if (valuesIndexes.ContainsKey(searchedValue) && valuesIndexes[searchedValue] != i)
            {
                return [i, valuesIndexes[searchedValue]];
            }
        }

        throw new Exception("Two Sum Not Found");
    }

    // Time Complexity: O(n)
    // Space Complexity: O(n)

     public int[] TwoSum3(int[] nums, int target) {
        
        var valuesIndexes = new Dictionary<int, int>();

        for(var i=0; i<nums.Length ; i++)
        {
            var searchedValue = target - nums[i];

            if(valuesIndexes.ContainsKey(searchedValue))
            {
                return [valuesIndexes[searchedValue], i];
            }

            valuesIndexes[nums[i]] =  i;
        }

        throw new Exception("Two Sum Not Found");
    }
}