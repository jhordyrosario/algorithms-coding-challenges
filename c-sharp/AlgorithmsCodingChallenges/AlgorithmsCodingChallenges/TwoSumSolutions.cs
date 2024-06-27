namespace AlgorithmsCodingChallenges;

public static class TwoSumSolutions
{
    public static int[] TwoSum(int[] nums, int target) {
        
        var result = new int[2];

        for(var i=0; i<=nums.Length-2 ; i++)
        {
            if(result[1] != 0)
            {
                break;
            }

            result[0] = i;

            for(var j=i+1; j<=nums.Length-1; j++)
            {
                if(target-nums[j] == nums[i])
                {
                    result[1] = j;
                    break;
                }     
            }
        }

        return result;
    }
}