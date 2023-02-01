using System;

namespace HomeWorkCS7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student std= new Student();
            Student std2= new Student();
            Student std3= new Student();
            Student std4= new Student();

            Console.WriteLine(std4.No);





            string GroupNo;
            do 
            {
                Console.WriteLine("GroupNo daxil edin : ");
                GroupNo= Console.ReadLine();

            }while(CorrectGroupNo(GroupNo)==false);
        
        
        
        }
        static bool CorrectGroupNo(string GroupNo)
        {
            if(string.IsNullOrWhiteSpace(GroupNo)|| GroupNo.Length != 4)
            {
                return false;
            }
            if (!char.IsUpper(GroupNo[0]))
            {
                return false;
            }
            for(int i=1;i<GroupNo.Length;i++)
            {
                if (!char.IsDigit(GroupNo[i]))
                {
                    return false;
                }
                
            }
            return true;
        }

    }
}
