using System.Data;

namespace CodeHere
{
    public class LogicHere
    {
        public string expression { get; set; } = string.Empty;
        public string result { get; set; } = string.Empty;
        public void Append(char c)
        {
            expression += c;
        }
        public void Clear()
        {
            expression = string.Empty;
            result = string.Empty;
        }
        public void Undo()
        {
            if (!string.IsNullOrEmpty(expression))
            {
                expression = expression.Substring(0, expression.Length - 1);
            }
        }
        public void EvaluateExpression()
        {
            try
            {
                var dataTable = new DataTable();
                var value = dataTable.Compute(expression, string.Empty);
                expression = value.ToString();
            }
            catch (Exception ex)
            {
                expression = "Error: " + ex.Message;
            }
        }
    }
}
