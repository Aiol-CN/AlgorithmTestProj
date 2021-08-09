using System;

using Xunit;

namespace AlgorithmTestProj
{
    /// <summary>
    /// 冒泡
    /// </summary>
    public class Bubble
    {
        private static readonly int[] correctResult = { 12, 25, 25, 36, 43, 48, 57, 65 };

        #region 正序

        /// <summary>
        /// 从数组头部开始 每轮检出最大值
        /// </summary>
        [Fact]
        public void AscToSelectMax()
        {
            int[] arr = { 36, 25, 48, 12, 25, 65, 43, 57 };

            int i, j;
            int len = arr.Length;
            int temp;
            for (i = 0; i < len - 1; ++i)
            {
                for (j = 0; j < len - 1; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Assert.Equal(correctResult, arr);
        }

        #endregion

        #region 倒序

        /// <summary>
        /// 从数组尾部开始 每轮检出最小值
        /// </summary>
        [Fact]
        public void DescToSelectMin()
        {
            int[] arr = { 36, 25, 48, 12, 25, 65, 43, 57 };

            int i, j;
            int len = arr.Length;
            int temp;
            for (i = 0; i < len - 1; ++i)
            {
                for (j = len - 1; j > i; --j)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }

            Assert.Equal(correctResult, arr);
        }

        #endregion

        #region 优化


        /* 更优化的思考
         * 
         * 每次循环后 将取得max/min 位 为本次循环中的最值 
         * 可在下次循环时不参与
         * 即 [3,2,4,1] 在一次循环 变为 [2,3,1,4] 后 4 不再参与下次比较
         
         */

        [Fact]
        public void BetterAscToSelectMax()
        {
            int[] arr = { 36, 25, 48, 12, 25, 65, 43, 57 };

            int i, j;
            int len = arr.Length;
            int temp;
            for (i = 0; i < len - 1; ++i)
            {
                for (j = 0; j < len - 1 - i; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Assert.Equal(correctResult, arr);
        }

        #endregion

    }
}
