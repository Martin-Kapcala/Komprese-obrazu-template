namespace Komprese
{
    public class KompreseObrazu{

        public static void Main (String [] args){
        
        

        //Cesta k testovacímu souboru "Upravit, dle svého PC!!!!"
        String testFilePath = @"C:\Users\MartinKapcala\OneDrive - Vítkovická střední průmyslová škola\Dokumenty\Programování\PG\Komprese-obrazu\KompreseObrazu\CSV\obr1-10.csv";
        
        //vytvoření instance třídy Obrazek, který se načte ze souboru
        
        Obrazek inputCSV = new Obrazek(testFilePath);

        
        
        //Test metody, která spočítá počet řádků vstupního obrázku
        Console.WriteLine("Počet vertikálních řádků {0}",inputCSV.CountLines(testFilePath));
        
        //Test metody, která spočítá počet symbolů vstupního obrázku v prvním řádku
        Console.WriteLine("Počet horizontální řádků {0}",inputCSV.CountSymbolInLine(testFilePath));

        //Test metody, která vytiskne obrázek
        inputCSV.vypisImg();

        //Test na vyhledávání unikátních barev, následný tisk.
        List<int> unikatniBarvy = inputCSV.PaletaBarevObrazku();

        Console.WriteLine("___________________________________________");


        //Tisk seznamu, kde josu uloženy unikátní barvy        
        Console.Write("Unikátní barvy: ");
        foreach(int element in unikatniBarvy){
            Console.Write($"{element}, ");
        }


        Console.WriteLine();
        
        //Test barev, kdy na základě unikátních barev zjistíme jejich počet v obrázku, rovnou s tiskem...
        foreach(int element in inputCSV.PocetUnikatnichBarev()){
            Console.WriteLine($"{element}, ");
        }

        var tree = new BinaryTree<int>();
 
        foreach(var value in new[]{8,5,6,4,1,2})
            tree.Add(value);
        

    }
    
}
}