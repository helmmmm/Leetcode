public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int elem = target - nums[i];
            if (dict.ContainsKey(elem))
                return new int[] {i, dict[elem]};
            else
                dict.TryAdd(nums[i], i);
        }
        return new int[0];
    }
}