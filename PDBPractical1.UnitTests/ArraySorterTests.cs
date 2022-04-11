using NUnit.Framework;
using PDBPractical1.StrategyViaDelegates;

namespace PDBPractical1.UnitTests;

[TestFixture]
public class ArraySorterTests
{
    [Test]
    public void SortRows_MinValueDesc_SortSuccess()
    {
        var actual = new[,]
        {
            { 1, 1, 4, 9 },
            { 10, 4, 2, 0 },
            { 8, 5, 14, 2 }
        };
        
        actual = actual.SortRows((x, y) => x < y, 
            (x, y) => x < y ? x : y);
        
        var expected = new[,]
        {
            { 8, 5, 14, 2 },
            { 1, 1, 4, 9 },
            { 10, 4, 2, 0 }
        };
        
        CollectionAssert.AreEqual(expected, actual);
    }
    
    [Test]
    public void SortRows_MinValueAsc_SortSuccess()
    {
        var actual = new[,]
        {
            { 1, 1, 4, 9 },
            { 10, 4, 2, 0 },
            { 8, 5, 14, 2 }
        };
        
        actual = actual.SortRows((x, y) => x > y, 
            (x, y) => x < y ? x : y);
        
        var expected = new[,]
        {
            { 10, 4, 2, 0 },
            { 1, 1, 4, 9 },
            { 8, 5, 14, 2 }
        };
        
        CollectionAssert.AreEqual(expected, actual);
    }
    
    [Test]
    public void SortRows_MaxValueDesc_SortSuccess()
    {
        var actual = new[,]
        {
            { 1, 1, 4, 9 },
            { 10, 4, 2, 0 },
            { 8, 5, 14, 2 }
        };
        
        actual = actual.SortRows((x, y) => x < y, 
            (x, y) => x > y ? x : y);
        
        var expected = new[,]
        {
            { 8, 5, 14, 2 },
            { 10, 4, 2, 0 },
            { 1, 1, 4, 9 }
        };
        
        CollectionAssert.AreEqual(expected, actual);
    }
    
    [Test]
    public void SortRows_MaxValueAsc_SortSuccess()
    {
        var actual = new[,]
        {
            { 1, 1, 4, 9 },
            { 10, 4, 2, 0 },
            { 8, 5, 14, 2 }
        };
        
        actual = actual.SortRows((x, y) => x > y, 
            (x, y) => x > y ? x : y);
        
        var expected = new[,]
        {
            { 1, 1, 4, 9 },
            { 10, 4, 2, 0 },
            { 8, 5, 14, 2 }
        };
        
        CollectionAssert.AreEqual(expected, actual);
    }
    
    [Test]
    public void SortRows_SumValueDesc_SortSuccess()
    {
        var actual = new[,]
        {
            { 1, 1, 4, 9 }, // 15
            { 10, 4, 2, 0 }, // 16
            { 8, 5, 14, 2 } // 29
        };
        
        actual = actual.SortRows((x, y) => x < y, 
            (x, y) => x + y);
        
        var expected = new[,]
        {
            { 8, 5, 14, 2 }, 
            { 10, 4, 2, 0 },
            { 1, 1, 4, 9 }
        };
        
        CollectionAssert.AreEqual(expected, actual);
    }
    
    [Test]
    public void SortRows_SumValueAsc_SortSuccess()
    {
        var actual = new[,]
        {
            { 1, 1, 4, 9 }, // 15
            { 10, 4, 2, 0 }, // 16
            { 8, 5, 14, 2 } // 29
        };
        
        actual = actual.SortRows((x, y) => x > y, 
            (x, y) => x + y);
        
        var expected = new[,]
        {
            { 1, 1, 4, 9 }, 
            { 10, 4, 2, 0 }, 
            { 8, 5, 14, 2 }
        };
        
        CollectionAssert.AreEqual(expected, actual);
    }
    
}