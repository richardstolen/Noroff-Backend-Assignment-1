using Back_end_Development_Assignment_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Tests.ItemTests
{
    public class ItemTests
    {
        [Fact]
        void ToString_AssertCorrectOutputToString_ShouldBeEqual()
        {
            Item item = new Item("test", 1, Slot.Body);

            string expected = $"{item.Name}\n      Required Level: {item.RequiredLevel}";

            Assert.Equal(expected, item.ToString());
        }
    }
}
