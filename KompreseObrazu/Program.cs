namespace Komprese
{
    public class KompreseObrazu{

        public static void Main (String [] args){
        
        //vytvoření instance třídy Obrazek
        Obrazek inputCSV = new Obrazek();

        //Cesta k testovacímu souboru
        String testFilePath = @"C:\Users\MartinKapcala\OneDrive - Vítkovická střední průmyslová škola\Dokumenty\Programování\PG\Komprese-obrazu\KompreseObrazu\CSV\obr1-10.csv";
        
        //Test metody, která načte vstupní obrázek
        inputCSV.readImg(testFilePath);
        
        //Test metody, která spočítá počet řádků vstupního obrázku
        Console.WriteLine("Počet vertikálních řádků {0}",inputCSV.CountLines(testFilePath));
        
        //Test metody, která spočítá počet symbolů vstupního obrázku v prvním řádku
        Console.WriteLine("Počet horizontální řádků {0}",inputCSV.CountSymbolInLine(testFilePath));

        inputCSV.vypisImg();
    }

    }
    
    
}