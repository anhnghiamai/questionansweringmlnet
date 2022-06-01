using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Text.Json;

namespace BertMlNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Bert("C:\\Users\\anhng\\source\\repos\\BertMlNet\\BertMlNet\\Assets\\Vocabulary\\vocab.txt",
                                "C:\\Users\\anhng\\source\\repos\\BertMlNet\\BertMlNet\\Assets\\Model\\bertsquad-10.onnx");

            var (tokens, probability) = model.Predict(args[0], args[1]);

            Console.WriteLine(JsonSerializer.Serialize(new
            {
                Probability = probability,
                Tokens = tokens
            }));
        }
    }
}
