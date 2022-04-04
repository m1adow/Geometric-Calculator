namespace Geometric_Calculator.Models;

public class Settings
{
    public static double[] GetValues(string[] values)
    {
        string[] actions = new string[] { "+", "-", "*", "/" }; //action chars

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
        if (values.Any(v => v.Any(c => c != ',' && !char.IsDigit(c) && !actions.Contains(c.ToString())))) throw new Exception("You must enter only numbers");

        if (values.Any(v => v.Any(c => actions.Contains(c.ToString()))))
        {
            List<string> valuesWithActions = values.Where(v => v.Any(c => c == '*' || c == '/' || c == '+' || c == '-')).ToList(); //collection with values which have actions

            for (int i = 0; i < valuesWithActions.Count; i++)
            {
                List<string> splitedValuesWithActions = valuesWithActions[i].Trim(' ').Select(x => new string(x, 1)).ToList(); //split string with action
                List<string>? containingActions = actions.Where(a => valuesWithActions[i].Any(c => c.ToString() == a)).ToList(); //find action chars which string has
                ActionSort(containingActions); //sort by action

                //solve expression while it has action signs
                while (splitedValuesWithActions.Any(c => actions.Contains(c.ToString())))
                {
                    for (int j = 0; j < containingActions.Count; j++)
                    {
                        int indexOfSplitedValueWithAction = Array.IndexOf(splitedValuesWithActions.ToArray(), containingActions[j]); //index of splited value with action

                        if (containingActions[j] == "+") splitedValuesWithActions[indexOfSplitedValueWithAction] = (double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction - 1].ToString()) + double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction + 1].ToString())).ToString();
                        else if (containingActions[j] == "-") splitedValuesWithActions[indexOfSplitedValueWithAction] = (double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction - 1].ToString()) - double.Parse(splitedValuesWithActions[indexOfSplitedValueWithAction + 1].ToString())).ToString();
                        //else if (containingActions[j] == '*') splitedValuesWithActions[j - 1] = Convert.ToChar(double.Parse(splitedValuesWithActions[j - 1].ToString()) * double.Parse(splitedValuesWithActions[j + 1].ToString()));
                        //else if (containingActions[j] == '/') splitedValuesWithActions[j - 1] = Convert.ToChar(double.Parse(splitedValuesWithActions[j - 1].ToString()) / double.Parse(splitedValuesWithActions[j + 1].ToString()));

                        ClearArrayAfterAction(splitedValuesWithActions, indexOfSplitedValueWithAction); //clear unnecessary elements
                        splitedValuesWithActions.ToList().ForEach(x => Console.WriteLine(x));
                    }
                }

                values[i] = splitedValuesWithActions.FirstOrDefault(s => s != string.Empty);
            }
        }

        double[] result = new double[values.Length]; //array for return

        for (int i = 0; i < result.Length; i++) result[i] = double.Parse(values[i]); //fill arrays with numbers from string array

        return result;
    }

    private static void ClearArrayAfterAction(List<string> collection, int index)
    {
        //to empty elements
        collection[index - 1] = string.Empty;
        collection[index + 1] = string.Empty;

        collection.RemoveAll(s => s == string.Empty); //clear all elements where string is empty
    }

    private static void ActionSort(List<string>? actions)
    {
        //sort array with preferable action
        for (int i = 0; i < actions?.Count; i++)
        {
            if (actions[i] == "*") ChangePosition(actions, i, actions[i]);
            else if (actions[i] == "/") ChangePosition(actions, i, actions[i]);
        }
    }

    private static void ChangePosition(List<string>? actions, int index, string action)
    {
        //examination for availability of preferable action at first place 
        if (actions[0] == "*" || actions[0] == "/")
        {
            actions[index] = actions[1];
            actions[1] = action;

            return;
        }

        actions[index] = actions[0];
        actions[0] = action;
    }
}