using Xunit;
using System.Collections.Generic;

public class ListManipulatorTests
{
    [Fact]
    public void FindMax_ListOfNumbers_ReturnsMaxValue()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var result = ListManipulator.FindMax(numbers);
        Assert.Equal(5, result);
    }

    [Fact]
    public void RemoveDuplicates_ListWithDuplicates_ReturnsListWithoutDuplicates()
    {
        var numbers = new List<int> { 1, 2, 3, 3, 4, 5, 5 };
        var result = ListManipulator.RemoveDuplicates(numbers);
        var expected = new List<int> { 1, 2, 3, 4, 5 };
        Assert.Equal(expected, result);
    }
}
