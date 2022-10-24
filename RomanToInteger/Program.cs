public class Solution
{
    int finalSum;
    string combination;
    List<string> explanations = new List<string> {};
    public int RomanToInt(string s)
    {
        if (s.Length < 1 || s.Length > 15) { Console.WriteLine("Некорректная длина"); return 0; }
        for (int i = 0; i < s.Length; i++)
        {
            string simbol = s.Substring(i, 1);
            switch (simbol)
            {
                case "I":
                    finalSum += 1;
                    if (i + 1 <= s.Length - 1)
                    {
                        if (s.Substring(i + 1, 1) == "V") { finalSum += 3; i++; explanations.Add("IV = 4 "); break; }
                        if (s.Substring(i + 1, 1) == "X") { finalSum += 9; i++; explanations.Add("IX = 9 "); break; }
                        
                    }
                    explanations.Add("I = 1 "); break;

                case "V":
                    finalSum += 5; explanations.Add("V = 5 ");
                    break;

                case "X":
                    finalSum += 10; 
                    if (i + 1 <= s.Length - 1)
                    {
                        if (s.Substring(i + 1, 1) == "L") { finalSum += 30; i++; explanations.Add("XL = 40 "); break; }
                        if (s.Substring(i + 1, 1) == "C") { finalSum += 80; i++; explanations.Add("XC = 90 "); break; }
                    }
                    explanations.Add("X = 10 "); break;

                case "L":
                    finalSum += 50; explanations.Add("L = 50 ");
                    break;

                case "C":
                    finalSum += 100; 
                    if (i + 1 <= s.Length - 1)
                    {
                        if (s.Substring(i + 1, 1) == "D") { finalSum += 300; i++; explanations.Add("CD = 400 "); break; }
                        if (s.Substring(i + 1, 1) == "M") { finalSum += 800; i++; explanations.Add("CM = 900 "); break; }
                    }
                    explanations.Add("C = 100 "); break;

                case "D":
                    finalSum += 500; explanations.Add("D = 500 ");
                    break;

                case "M":
                    finalSum += 1000; explanations.Add("M = 1000 ");
                    break;

                default:
                    Console.WriteLine("Вы ввели некорректную комбинацию!"); explanations.Clear(); 
                    return 0;
            }
        }
        return finalSum;
    }
    static void Main(string[] args)
    {
        Solution s = new Solution();
        
            s.combination = Console.ReadLine();
            Console.Write("Input: s = " + s.combination + "\n" +
                              "Output: " + s.RomanToInt(s.combination) + "\n" + "Explanation: ");

            foreach (var item in s.explanations) Console.Write(item);
    }
    
}



