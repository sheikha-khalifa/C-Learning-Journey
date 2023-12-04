namespace Inheritance_and_Abstration
{
 // example on get ,set , indexer, methods, costructor
    internal class Program
    {
        
        static void Main(string[] args)
        {
            phoneBook myphone = new phoneBook(5);
            myphone.addperson( "sheikha", 98765433);
            myphone.addperson( "maitha", 96065433);
            myphone.addperson( "kholood", 53698873);
            myphone.GetAllNames();
            //Console.WriteLine( myphone.getnumber("sheikha"));
            //Console.WriteLine(myphone.getname(96065433));
            //myphone.editnumber("sheikha",94575079);

            Console.WriteLine(myphone["sheikha"]);//get from indexer (indexer treat object as array when access it) 
            //myphone["maitha"] = 99887777;//set using indexer
            myphone["ahmed"]= 99887777;//add  indexer from set
            myphone["ahmed",true] = 2676377737;//edit 
            myphone.GetAllNames();

        }
    }
}