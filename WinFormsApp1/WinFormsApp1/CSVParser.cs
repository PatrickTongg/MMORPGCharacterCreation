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
        Adaptor adaptor;
        public CSVParser(string filePath)
        {
            storage = DataStorage.Instance;
            parser = new TextFieldParser (filePath);
            

        }

        public void ConverterToCharacter()
        {
            int sucessCounter = 0;
            int skipCounter = 0;
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                string[] stringData = parser.ReadFields();
                try
                {
                    adaptor = new Adaptor();
                    string race = stringData[0];
                    string clazz = stringData[1];
                    string abilities = stringData[2];
                    string appearance = stringData[3];
                    storage.CharacterList.Add( adaptor.StringToCharater(race, clazz, abilities,appearance));
                    sucessCounter++;
                }
                catch
                { 
                    skipCounter++;
                }
            }
            MessageBox.Show($"Sucess Record: {sucessCounter}\nSkip Record:{skipCounter}","info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
