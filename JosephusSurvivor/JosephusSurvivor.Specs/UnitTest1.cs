using Machine.Specifications;

namespace JosephusSurvivor.Specs
{
    public class When_Filtering_Out_Third_Character
    {
        Establish context = () =>
        {
            mod = new[] { 3, 3, 4632 };
            input = new[] { 30, 7, 2952 };
            expect = new[] {29, 4, 463 };
            answer = new int[input.Length];
        };

        Because of = () =>
        {
            for (var i = 0; i < input.Length; i++)
            {
                answer[i] = Josephus.JosSurvivor(input[i], mod[i]);
            }
        };

        It Should_Return_The_Array_Without_Removed_Value = () => answer.ShouldEqual(expect);

        static int[] mod;
        static int[] input;
        static int[] expect;
        static int[] answer;
    }
}