using Lab2;

namespace Tests
{
    [TestClass]
    public sealed class Test1
    {
        
            [TestMethod]
            public void Sort_SimpleArray_ReturnsSortedArray()
            {
                int[] input = { 5, 3, 8, 1 };
                int[] result = CombSort.Sort((int[])input.Clone());

                CollectionAssert.AreEqual(new int[] { 1, 3, 5, 8 }, result);
            }

            [TestMethod]
            public void Sort_ArrayWithDuplicates_SortsCorrectly()
            {
                int[] input = { 4, 1, 4, 2, 1 };
                int[] expected = { 1, 1, 2, 4, 4 };

                int[] result = CombSort.Sort((int[])input.Clone());

                CollectionAssert.AreEqual(expected, result);
            }

            [TestMethod]
            public void Sort_AllEqualValues_ReturnsSameArray()
            {
                int[] input = { 7, 7, 7, 7 };
                int[] result = CombSort.Sort((int[])input.Clone());

                CollectionAssert.AreEqual(input, result);
            }

            [TestMethod]
            public void Sort_EmptyArray_ReturnsEmptyArray()
            {
                int[] input = { };
                int[] result = CombSort.Sort((int[])input.Clone());

                CollectionAssert.AreEqual(input, result);
            }
    }
}
