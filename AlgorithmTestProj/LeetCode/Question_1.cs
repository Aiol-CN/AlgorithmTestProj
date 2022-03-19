using System;
using System.Collections;

namespace AlgorithmTestProj.LeetCode
{
    /// <summary>
    /// 第一题：两数之和
    /// </summary>
    public class Question_1
    {
        #region - 问题 -
        /*   描述：
         *   
         *   给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target  的那 两个 整数，并返回它们的数组下标。
         *   你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。你可以按任意顺序返回答案。
         *   
         *   示例：
         *   
         *   输入：nums = [2,7,11,15], target = 9
         *   输出：[0,1]
         *   解释：因为 nums[0] + nums[1] == 9 ，返回 [0, 1] 。
         *   
         */
        #endregion

        #region - 解法 -

        #region - 暴力破解 -
        public int[] TwoSum_Forced(int[] nums, int target)
        {
            var res = new int[2];
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    // 以i为基数遍历后面的所有数 
                    // 而j在循环的时候 其之前的数字必定已经被循环过了 即以i+1为初始值
                    if (nums[i] + nums[j] == target)
                    {
                        res[0] = i;
                        res[1] = j;
                        // 直接返回 否则在得出结果后依然会继续循环 浪费时间
                        return res;
                    }
                }
            }
            // 结束所有循环后依然没有得到合理解 
            return res;
        }
        #endregion
        // 执行用时: 296 ms / beats 53% C# submitters
        // 内存消耗: 32 MB / beats 15% C# submitters

        #region - 最小空间 -

        public int[] TwoSum_MinS(int[] nums, int target)
        {
            var temp = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                // 逐数求差
                temp = target - nums[i];
                var index = Array.IndexOf(nums, temp);
                if (index >= 0 && index != i)
                {
                    return new int[2] { i, index };
                }
            }
            return null;
        }
        #endregion
        // 执行用时: 500 ms / beats 6% C# submitters
        // 内存消耗: 31.5 MB / beats 49% C# submitters

        #region - 最小时间 -
        public int[] TwoSum_MinT(int[] nums, int target)
        {
            var ht = new Hashtable();
            for (var i = 0; i < nums.Length; i++)
            {
                if (!ht.ContainsKey(target - nums[i]))
                {
                    // 不存在指定值的键 插入等待下一个
                    ht.Add(nums[i], i);
                }
                else
                {
                    return new int[] { i, (int)ht[target - nums[i]] };
                }
            }
            return null;
        }
        #endregion
        // 执行用时: 220 ms / beats 100% C# submitters
        // 内存消耗: 32.9 MB / beats 5.03% C# submitters

        #endregion
    }
}
