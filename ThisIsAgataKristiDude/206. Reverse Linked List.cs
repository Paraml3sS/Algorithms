using FluentAssertions;
using Xunit;

namespace ReverseLinkedList
{
    public class MakeItWorkDude
    {
        [Fact]
        public void FullArray()
        {
            ThisIsAlgoDude dude = new();

            ListNode node4 = new(4);
            ListNode node3 = new(3, node4);
            ListNode node2 = new(2, node3);
            ListNode node1 = new(1, node2);
            ListNode node0 = new(0, node1);

            var reversed = dude.SolveThisShitBroooo(node0);

            reversed.val.Should().Be(4);
            reversed.next.val.Should().Be(3);
            reversed.next.next.val.Should().Be(2);
            reversed.next.next.next.val.Should().Be(1);
            reversed.next.next.next.next.val.Should().Be(0);
        }


        [Fact]
        public void NoElements()
        {
            ThisIsAlgoDude dude = new();

            var reversed = dude.SolveThisShitBroooo(null);

            reversed.Should().BeNull();
        }

        [Fact]
        public void OneElement()
        {
            ThisIsAlgoDude dude = new();

            var reversed = dude.SolveThisShitBroooo(new ListNode());

            reversed.val.Should().Be(0);
        }
    }


    public class ThisIsAlgoDude
    {
        public ListNode SolveThisShitBroooo(ListNode head)
        {
            return ShawtyHelp(head, head?.next);
        }

        public ListNode ShawtyHelp(ListNode head, ListNode nextNode)
        {
            if (head is null || nextNode is null)
            {
                return head;
            }

            var afterNext = nextNode.next;
            nextNode.next = head;

            return ShawtyHelp(nextNode, afterNext);
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
