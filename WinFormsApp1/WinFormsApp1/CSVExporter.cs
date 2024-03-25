using RpgCharaterCreation.Adaptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    internal class CSVExporter
    {
        DataStorage storage;
        string filePath;
        
        public CSVExporter(string path) 
        {
            storage = DataStorage.Instance;
            filePath = path;
        }
        public void exportCSV()
        {
            List<Character> characterList = storage.CharacterList;
            var csv = new StringBuilder();
            for (int i =0;i< characterList.Count;i++)
            {
                try
                {
                    AdaptorCharactorToString adaptor = new AdaptorCharactorToString();
                    string stringData = adaptor.ConvertCharacterToString(characterList[i]);
                    csv.AppendLine(stringData);
                }
                catch
                {
                    MessageBox.Show($"Error occure the No.{i + 1} Charater, will proceed to the next Charater", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
            }
            if (csv.Length > 0)
            {
                File.WriteAllText(filePath, csv.ToString());
                MessageBox.Show($"Exporting Done", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }
    }
}
