using System.IO;

namespace Task7
{
    class Program
    {
        static void Main()
        {
            string[] words;
            using (StreamReader sr = new StreamReader("Inlet.in"))
            {
                words = sr.ReadToEnd().Trim().Split(' ');
            }
            string result = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                char[] tmp = words[i].ToCharArray();
                for (int j = 1; j < tmp.Length; j++)
                {
                    if (tmp[j] == tmp[0])
                    {
                        tmp[j] = '_';
                    }
                }
                result += new string(tmp) + " ";
            }
            File.WriteAllText("Outlet.out", result);
        }
    }
}
