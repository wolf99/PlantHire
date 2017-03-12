
namespace FisherPlantHire
{
    class HirerFactory : RecordFactory
    {
        public override Record MakeRecord(string[] fields)
        {
            return new Hirer(fields);
        }
    }

    class Hirer : Record
    {
        enum Field
        {
            Code = 0,
            Name,
            AddressLn1,
            AddressLn2,
            AddressLn3,
            AddressLn4,
            AddressLn5,
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string AddressLn1 { get; set; }
        public string AddressLn2 { get; set; }
        public string AddressLn3 { get; set; }
        public string AddressLn4 { get; set; }
        public string AddressLn5 { get; set; }

        internal Hirer(string[] csvFields)
        {
            Field f = Field.Code;
            try
            {
                Code = string.Copy(csvFields[(int)f]);
                Name = string.Copy(csvFields[(int)++f]);
                AddressLn1 = string.Copy(csvFields[(int)++f]);
                AddressLn2 = string.Copy(csvFields[(int)++f]);
                AddressLn3 = string.Copy(csvFields[(int)++f]);
                AddressLn4 = string.Copy(csvFields[(int)++f]);
                AddressLn5 = string.Copy(csvFields[(int)++f]);
            }
            catch (System.IndexOutOfRangeException e)
            {
                throw new System.ArgumentException("Hirer parse failed", f.ToString(), e);
            }
        }
    }
}
