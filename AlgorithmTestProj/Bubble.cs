using System;

using Xunit;

namespace AlgorithmTestProj
{
    /// <summary>
    /// ð��
    /// </summary>
    public class Bubble
    {
        private static readonly int[] correctResult = { 12, 25, 25, 36, 43, 48, 57, 65 };

        #region ����

        /// <summary>
        /// ������ͷ����ʼ ÿ�ּ�����ֵ
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

        #region ����

        /// <summary>
        /// ������β����ʼ ÿ�ּ����Сֵ
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

        #region �Ż�


        /* ���Ż���˼��
         * 
         * ÿ��ѭ���� ��ȡ��max/min λ Ϊ����ѭ���е���ֵ 
         * �����´�ѭ��ʱ������
         * �� [3,2,4,1] ��һ��ѭ�� ��Ϊ [2,3,1,4] �� 4 ���ٲ����´αȽ�
         
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
