// See https://aka.ms/new-console-template for more information
namespace modul4_1302210115
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            KodeBuah table_Kodepos = new KodeBuah();
            Console.WriteLine("==== Nama Buah dan Kode Buah ====");
            table_Kodepos.getAllkodepos();

            Console.WriteLine("==== DOOR KEY ====");

            

        }

    }
}

class KodeBuah
{
    Dictionary<string, string> dic = new Dictionary<string, string>() {
            {"Apel", "A00"},
            {"Aprikot","B00" },
            {"Alpukat","C00" },
            {"Pisang","D00" },
            {"Paprika","E00"},
            {"Blackberry","F00" },
            {"Ceri","H00"},
            {"Kelapa","I00" },
            {"Jagung","J00"},
            {"Kurma","K00"},
            {"Durian","L00"},
            {"Anggur","M00" },
            {"Melon","N00" },
            {"Semangka","O00" } };
    public void getKodepos(string buah)
    {
        if (dic.ContainsKey(buah))
        {
            Console.WriteLine(buah + " : " + dic[buah]);
        }
        else
        {
            Console.WriteLine(buah + " Not Founded ");
        }
    }
    public void getAllkodepos()
    {
        foreach (KeyValuePair<string, string> ele1 in dic)
        {
            Console.WriteLine("{0} \t\t {1}", ele1.Key, ele1.Value);
        }
    }
}


