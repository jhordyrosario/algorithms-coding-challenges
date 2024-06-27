# Problem Description
Two Sum is a classic algorithm problem where you are given an array of integers nums and an integer target. Your task is to find two numbers in nums such that they add up to the target. The function should return the indices of these two numbers. Each input will have exactly one solution, and the same element may not be used twice.

# Examples
Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]

#Constraints
2 <= nums.length <= 10^4
-10^9 <= nums[i] <= 10^9
-10^9 <= target <= 10^9

Only one valid answer exists.

#Follow-up
Can you come up with an algorithm that is less than O(n^2) time complexity?