namespace AlgorithmsCodingChallenges;

public class TwoSumSolutions
{
    public int[] TwoSum(int[] nums, int target) {
        
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
}