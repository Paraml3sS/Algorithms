using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/linked-list-cycle
/// 
///

namespace LinkedListCycle
{
    public class MakeItWorkDude
    {
        [Fact]
        public void Cycle()
        {
            ThisIsAlgoDude dude = new();

            ListNode node4 = new(4);
            ListNode node3 = new(3, node4);
            ListNode node2 = new(2, node3);
            ListNode node1 = new(1, node2);
            ListNode node0 = new(0, node1);

            node4.next = node1;

            var dumbShit = dude.SolveThisShitBroooo(node0);

            dumbShit.Should().Be(true);
        }

        [Fact]
        public void NoCycle()
        {
            ThisIsAlgoDude dude = new();

            ListNode node4 = new(4);
            ListNode node3 = new(3, node4);
            ListNode node2 = new(2, node3);
            ListNode node1 = new(1, node2);
            ListNode node0 = new(0, node1);

            var dumbShit = dude.SolveThisShitBroooo(node0);

            dumbShit.Should().Be(false);
        }
    }


        public class ThisIsAlgoDude
    {
        public bool SolveThisShitBroooo(ListNode head)
        {
            HashSet<ListNode> visited = new ();
            ListNode current = head;
            while (current is not null)
            {
                if (visited.Contains(current))
                {
                    return true;
                }
                visited.Add(current);
                current = current.next;
            }
            return false;
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
    }
}
