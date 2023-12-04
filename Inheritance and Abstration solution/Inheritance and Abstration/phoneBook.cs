using System.Runtime.Intrinsics.X86;

namespace Inheritance_and_Abstration
{
    internal class phoneBook
    {
        //its by defualt private members
        public static int cnt;
        string[] Names;
        long[] Numbers;
        int Size;
       
     

        #region constructor  
        public phoneBook(int Size)
        {
            this.Size = Size;
            this.Names = new string[Size];
            this.Numbers = new long[Size];
        } 
        #endregion
        public int GetSize()
        {
            return this.Size;
        }
        public void addperson(string Name, long Number)
        {
            
            
            this.Names[cnt] = Name;
            this.Numbers[cnt] = Number;
            cnt += 1;
        }
        public void GetAllNames()
        {
            for (int i = 0; i < Size; i++) 
            {
                if (this.Names[i] != null)
                Console.WriteLine($"{i+1} {this.Names[i]} || {this.Numbers[i]}");
            }

        }
        public long getnumber(string name)
        {
            for (int i = 0; i < this.Size; i++)
            {
                if (Names[i] == name)
                    return this.Numbers[i];
            }
            return -1; 
        }
        public string getname(long number)
        {
            for (int i = 0; i < this.Size; i++)
            {
                if (Numbers[i] == number)
                    return this.Names[i];
            }
            return "Notfound";
        }
        public void editnumber(string name,long number)
        {
            for (int i = 0; i < this.Size; i++)
            {
                if (Names[i] == name)
                     this.Numbers[i]=number;
                Console.WriteLine($"{this.Names[i]} is updated with number: {this.Numbers[i]}");
                
            }
           
        }
        //indexer treat object as array when access it 

        public long this[string name, bool flag=false]
        {
            //get number value for the name specified.
            get
            {
                for (int i = 0; i < this.Size; i++)
                {
                    if (Names[i] == name)
                        return this.Numbers[i];
                }
                return 0;
            }
            //add new || edit old || (add&& edit)
            set
            {
                if (!flag)//add new
                {
                    Names[cnt] = name;
                    Numbers[cnt] = value;
                    cnt += 1;
                }
                else//edit old
                {
                    for (int i = 0; i < this.Size; i++)
                    {
                        if (Names[i] == name)
                            
                            this.Numbers[i] = value;
                       

                    }
                }
            }
        }
    }
}
