using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/merge-two-sorted-lists
/// 
///

namespace MergeTwoSortedLists
{
    public class MakeItWorkDude
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 2, 9, 13 }, new int[] { 1, 1, 2, 2, 4, 9, 13 })]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[] { 1 }, new int[] { }, new int[] { 1 })]
        [InlineData(new int[] { 2 }, new int[] { 1 }, new int[] { 1, 2 })]
        public void SolutionTest(int[] list1, int[] list2, int[] realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbShit = dude.SolveThisShitBrooooNice(
                ListNode.CreateLinkedList(list1), 
                ListNode.CreateLinkedList(list2)
            );

            dumbShit.Enumerate().Should().Equal(realShit);
        }

    }


    public class ThisIsAlgoDude
    {
        public ListNode SolveThisShitBrooooNice(ListNode list1, ListNode list2) => ShawtyHelpppp(list1, list2);

        public ListNode ShawtyHelpppp(ListNode list1, ListNode list2)
        {
            if (list1 is null) return list2;
            if (list2 is null) return list1;

            if (list1.val < list2.val)
            {
                list1.next = ShawtyHelpppp(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = ShawtyHelpppp(list1, list2.next);
                return list2;
            }
        }



        public ListNode SolveThisShitBroooo(ListNode list1, ListNode list2) 
        {
            if (list1 is null && list2 is null)
                return null;

            if (list1 is null && list2 is not null)
                return list2;

            if (list1 is not null && list2 is null)
                return list1;




            if (list1.val < list2?.val)
            {
                ShawtyHelp(list1, list2);
                return list1;
            }
            else
            {
                ShawtyHelp(list2, list1);
                return list2;
            }
        } 

        public void ShawtyHelp(ListNode firstHead, ListNode secondHead, ListNode prev = null)
        {
            if (firstHead is null) return;
            if (secondHead is null) return;

            if (firstHead.val < secondHead.val)
            {
                if (firstHead.next is null)
                {
                    firstHead.next = secondHead;
                    return;
                }

                ShawtyHelp(firstHead.next, secondHead, firstHead);
            }
            else
            {
                ListNode secondHeadNext = secondHead.next;
                ListNode firstHeadNode = prev ?? firstHead;

                ListNode endLink = firstHeadNode.next;
                firstHeadNode.next = secondHead;
                secondHead.next = endLink;

                ShawtyHelp(firstHeadNode, secondHeadNext);
            }
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public IEnumerable<int> Enumerate()
        {
            ListNode head = this;

            while (head != null)
            {
                yield return head.val;
                head = head.next;
            }
        }

        public static ListNode CreateLinkedList(params int[] values)
        {
            if (values.Count() == 0)
                return null;

            ListNode head, prev = new(values.First());
            head = prev;

            for (int i = 1; i < values.Length; i++)
            {
                ListNode node = new(values[i]);
                prev.next = node;
                prev = node;
            }

            return head;
        }
    }
}
