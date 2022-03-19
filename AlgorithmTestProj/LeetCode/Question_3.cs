using System.Collections.Generic;
using System.Linq;

using Xunit;

namespace AlgorithmTestProj.LeetCode
{
    /// <summary>
    /// 第三题 ： 无重复的最长子串
    /// </summary>
    public class Question_3
    {
        // private static string s = "abcabcbb";
        // private static string s = "pwwkew";
        private static string s = "wobgrovw";
        // private static string s = " ";

        #region 解法 1.0

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

    }
}
