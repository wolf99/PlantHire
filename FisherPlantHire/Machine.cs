
using System.Globalization;

namespace FisherPlantHire
{
    class MachineFactory : RecordFactory
    {
        public override Record MakeRecord(string[] fields)
        {
            return new Machine(fields);
        }
    }

    class Machine : Record
    {
        private enum Field
        {
            Code = 0,
            DetailLn1,
            DetailLn2,
            DetailLn3,
            DetailLn4,
            DetailLn5,
            WeeklyRate,
            DailyRate,
        }

        // Strings implement IComparable, handy for sorting!
        public string Code { get; set; }
        public string DetailLn1 { get; set; }
        public string DetailLn2 { get; set; }
        public string DetailLn3 { get; set; }
        public string DetailLn4 { get; set; }
        public string DetailLn5 { get; set; }
        public decimal WeeklyRate { get; set; }
        public decimal DailyRate { get; set; }

        public Machine()
        {
            // Empty constructor, default is overloaded by internal Machine() below
        }

        internal Machine(string[] csvFields)
        {
            Field f = Field.Code;
            try
            {
                Code = string.Copy(csvFields[(int)f]);
                DetailLn1 = string.Copy(csvFields[(int)++f]);
                DetailLn2 = string.Copy(csvFields[(int)++f]);
                DetailLn3 = string.Copy(csvFields[(int)++f]);
                DetailLn4 = string.Copy(csvFields[(int)++f]);
                DetailLn5 = string.Copy(csvFields[(int)++f]);

                if (string.IsNullOrEmpty(csvFields[(int)++f]))
                    WeeklyRate = 0;
                else
                    WeeklyRate = decimal.Parse(csvFields[(int)f], NumberStyles.Currency);

                if (string.IsNullOrEmpty(csvFields[(int)++f]))
                    DailyRate = 0;
                else
                    DailyRate = decimal.Parse(csvFields[(int)f], NumberStyles.Currency);
            }
            catch (System.Exception e) when (e is System.FormatException || e is System.IndexOutOfRangeException)
            {
                throw new System.ArgumentException("Machine parse failed", f.ToString(), e);
            }
        }

        public override string ToString()
        {
            // Concatenate all the property strings
            string s =
                string.Join(",",
                new string[] { Code, DetailLn1, DetailLn2, DetailLn3, DetailLn4, DetailLn5,
                    WeeklyRate.ToString("F2", CultureInfo.InvariantCulture),
                    DailyRate.ToString("F2", CultureInfo.InvariantCulture) });
            return s;
        }
    }
}
