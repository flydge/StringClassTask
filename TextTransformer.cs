using System;
using System.Text;

namespace StringClassTask
{
    public class TextTransformer
    {
        public string TransformToUpper(String text)
        {
            string outputText;
            if (!String.IsNullOrWhiteSpace(text))
            {
                string[] splitedText = text.Split(' ');
                StringBuilder stringBuilder = new StringBuilder(String.Empty);
                foreach (var word in splitedText)
                {
                    stringBuilder.Append((word + "||").ToUpper());
                }
                outputText = stringBuilder.ToString();
            }
            else
            {
                outputText = "String is empty"; 
            }
            
            
            return outputText;
        }
    }
}