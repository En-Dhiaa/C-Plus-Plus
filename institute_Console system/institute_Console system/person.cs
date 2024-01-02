using System;


namespace institute_Console_system
{
   abstract class person
    {

        
        //attributes
        private int id;
        private string name;
        private string phone;
        private int age;
        private string birth;
        private string adderss;
        //property
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Birth { get { return birth; } set { birth = value; } }
        public string Adderss { get { return adderss; } set { adderss = value; } }

        //methods
        public abstract void Add();
        
        public virtual void Show()
        {
            
           
        }
        public abstract void Update();
        
        public virtual void Delete()
        {
            id = 0; age = 0;
            name = null; birth = null;
            phone = null; adderss = null;
            Console.WriteLine(".......Deleted successfully......... \n");

        }

        
    }
}
