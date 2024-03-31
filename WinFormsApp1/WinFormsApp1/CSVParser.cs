using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCharaterCreation.Builder;

namespace RpgCharaterCreation
{
    public class CSVParser
    {
        DataStorage storage;
        TextFieldParser parser;
        AdaptorStringToChar adaptor;
        Queue<string[]> strings;
        public CSVParser(string filePath)
        {
            storage = DataStorage.Instance;
            parser = new TextFieldParser (filePath);
            strings = new Queue<string[]> ();
            

        }

        public void ConverterToCharacter()
        {

            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                string[] stringData = parser.ReadFields();
                strings.Enqueue(stringData);
            }
            CharaterConversion(strings);
        }
       
        public void CharaterConversion(Queue<string[]>strings) {
                int sucessCounter = 0;
                int skipCounter = 0;
                int count = strings.Count;
            for (int i = 0; i < count; i++)
            {
                try
                {
                    string[] stringData = strings.Dequeue();
                    if(stringData[0] == "Race"&& stringData[1] == "Class"&& stringData[2]=="Ability"&&stringData[3]=="Appearance")
                    {
                        continue;
                    }
                    adaptor = new AdaptorStringToChar(stringData);
                    storage.CharacterList.Add(adaptor);
                    sucessCounter++;
                }
                catch
                {
                    skipCounter++;
                }
            }

            MessageBox.Show($"Sucess Record: {sucessCounter}\nSkip Record:{skipCounter}", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
