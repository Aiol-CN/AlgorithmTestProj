using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTestProj.LeetCode
{
    /// <summary>
    /// 第二题：两数相加
    /// </summary>
    public class Question_2
    {
        #region - 问题 -
        /*   描述：
         *   
         *   给你两个非空的链表，表示两个非负的整数。它们每位数字都是按照逆序的方式存储的，并且每个节点只能存储一位数字。
         *   请你将两个数相加，并以相同形式返回一个表示和的链表。你可以假设除了数字0之外，这两个数都不会以0开头。
         *   
         *   示例
         *   输入：l1 = [2,4,3], l2 = [5,6,4]
         *   输出：[7,0,8]
         *   解释：342 + 465 = 807
         *   
         */
        #endregion

        #region - 解法 -

        #region - 解法1 -

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var carry = 0;
            var headNode = new ListNode(0);
            var curNode = headNode;

            //存在下一节点或进位上有值时则必须统计
            while (carry != 0 || l1 != null || l2 != null)
            {

                // 计算当前位 val
                var curVal = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
                // 设置节点
                curNode.next = new ListNode(curVal % 10);
                curNode = curNode.next;
                // 设置carry
                carry = curVal / 10;
                // 将l1 l2 设置为下一个节点
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }
            return headNode.next;
        }

        #endregion
        // 执行用时: 96 ms / beats 100% C# submitters
        // 内存消耗: 27.6 MB / beats 60% C# submitters

        #endregion
    }

    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
