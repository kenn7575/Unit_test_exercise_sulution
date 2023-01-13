
using Unit_test_exercise_project;
namespace Unit_test_exercise_project_tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(654, 1 )]
        [InlineData(2222, 1)]
        [InlineData(0, 0)]


        public void Test1(int i, int expected)
        {
            //arange
            var program = new Program();
            
            //act
            int actual = program.abc(i);

            //assess
            Assert.Equal(actual, expected);
        }
    }
}