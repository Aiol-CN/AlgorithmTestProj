using System.Collections.Generic;
using System.Linq;

using Xunit;

namespace AlgorithmTestProj.LeetCode
{
    /// <summary>
    /// 第三题：无重复的最长子串
    /// </summary>
    public class Question_3
    {
        #region - 问题 -
        /*   描述：
         *   
         *   给定一个字符串 s ，请你找出其中不含有重复字符的 最长子串 的长度。
         *   
         *   示例：
         *   
         *   输入: s = "abcabcbb"
         *   输出: 3 
         *   解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
         *   
         */
        #endregion

        #region - 样例 -
        // private static string s = "abcabcbb";
        // private static string s = "pwwkew";
        private static string s = "wobgrovw";
        // private static string s = " ";
        #endregion

        #region - 解法 -

        #region 解法1
        [Fact]
        public void LengthOfLongestSubstring()
        {
            var res = 0;
            var len = s.Length;
            List<char> list = new List<char>();
            for (var i = 0; i < len; i++)
            {
                if (res < len - i)
                {
                    foreach (var b in s)
                    {

                        if (!list.Contains(b))
                        {
                            list.Add(b);
                        }
                        else
                        {
                            // 重复
                            if (res < list.Count())
                            {
                                res = list.Count();
                            }
                            list.Clear();
                            s = s.Substring(1, s.Length - 1);
                            break;
                        }
                    }
                    // 结束本轮流程
                    if (res < list.Count())
                    {
                        res = list.Count();
                    }
                    list.Clear();
                }
            }
            Assert.Equal(6, res);
        }
        #endregion
        // 执行用时：156 ms, 在所有 C# 提交中击败了 19.01% 的用户
        // 内存消耗：60.6 MB, 在所有 C# 提交中击败了 5.14% 的用户

        #endregion

    }
}
