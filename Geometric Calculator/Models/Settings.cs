namespace Geometric_Calculator.Models;

public class Settings
{
    public static double[] GetValues(string[] values)
    {
        char[] actions = new char[] { '+', '-', '*', '/' }; //action chars

        //change dot to comma
        while (values.Any(v => v.Any(c => c == '.')))
        {
            string? word = values.FirstOrDefault(v => v.Any(c => c == '.')); //get word from array which contains dot

            //examination for null reference
            if (word == null) throw new Exception("You must enter something");

            int index = Array.IndexOf(values, word); //get word index in array

            values[index] = word.Replace('.', ',');
        }

        //examination for containing not numbers inside string
        if (values.Any(v => v.Any(c => c != ',' && !char.IsDigit(c) && !actions.Contains(c)))) throw new Exception("You must enter only numbers");

        if (values.Any(v => v.Any(c => actions.Contains(c))))
        {
            List<string> valuesWithActions = values.Where(v => v.Any(c => c == '*' || c == '/' || c == '+' || c == '-')).ToList(); //collection with values which have actions

            valuesWithActions.ForEach(x => Console.WriteLine(x));

            foreach (var item in valuesWithActions)
            {
                int indexOfValueWithAction = Array.IndexOf(values, item); //index of item in original array

                char[] splitedValuesWithActions = item.Trim(' ').ToCharArray(); //split string with action

                splitedValuesWithActions.ToList().ForEach(x => Console.WriteLine(x));

                //20 + 3 * 80 * 9

                while (splitedValuesWithActions.Any(s => actions.Contains(s)))
                {
                    var containingActions = actions.Where(a => splitedValuesWithActions.Any(s => s == a)); //find action chars which string has

                    containingActions.ToList().ForEach(x => Console.WriteLine(x));

                    foreach (var action in containingActions)
                    {
                        int indexOfSplitedValueWithAction = Array.IndexOf(splitedValuesWithActions, action); //index of splited value with action

                        if (action == '+') values[indexOfValueWithAction] = (double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction - 1].ToString()) + double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction + 1].ToString())).ToString(); //splitedValuesWithActions[indexOfSplitedValueWithAction - 1] = Convert.ToChar(double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction - 1].ToString()) + double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction + 1].ToString()));
                        else if (action == '-') splitedValuesWithActions[indexOfSplitedValueWithAction - 1] = Convert.ToChar(double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction - 1].ToString()) - double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction + 1].ToString()));
                        else if (action == '*') splitedValuesWithActions[indexOfSplitedValueWithAction - 1] = Convert.ToChar(double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction - 1].ToString()) * double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction + 1].ToString()));
                        else if (action == '/') splitedValuesWithActions[indexOfSplitedValueWithAction - 1] = Convert.ToChar(double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction - 1].ToString()) / double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction + 1].ToString()));

                        ClearArrayAfterAction(splitedValuesWithActions, indexOfSplitedValueWithAction); //clear unnecessary elements
                    }
                }

                splitedValuesWithActions.ToList().ForEach(x => Console.WriteLine(x));
            }
        }

        double[] result = new double[values.Length]; //array for return

        for (int i = 0; i < result.Length; i++) result[i] = double.Parse(values[i]); //fill arrays with numbers from string array

        return result;
    }

    private static void ClearArrayAfterAction(char[] array, int index)
    {
        array[index] = '\0';
        array[index + 1] = '\0';
    }
}