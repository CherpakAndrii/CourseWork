namespace WinFormsApp1.Model
{
    public class AnswerCalculator
    {
        public static Range? GetAnswer()
        {
            Inequality[] inputs = InequalitiesFactory.GetInequalities();
            Range answer = new Range(null, null);
            foreach (var inequality in inputs)
            {
                answer = answer & inequality.Range;
                if (answer.IsNull) break;
            }
            return answer.IsNull?null:answer;
        }
    }
}