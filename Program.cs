// Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100.

namespace Programm{
    class NumbersFromRangeTask{

        public static void Main (){
            //création de la liste
            List <int> Numbers = new  List <int>{ 30, 54, 3, 14, 25, 82, 1, 100, 23, 95 };

            // Création criteres custom
            static int Modulo (int i , int j){
                 return (i)%(j) ;
                 }
            

            // selectionner les entiers
            var ArrInt = Numbers.Where(x=> x > 30).Where(x=> x < 100);

            foreach (var item in ArrInt)
            {
                Console.Write (item + ", ");
            }

        }
    }
}