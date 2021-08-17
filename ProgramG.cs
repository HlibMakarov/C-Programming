
using System;


namespace ProjectG
{
    class NewTestProgramm
    {
        public static void Main(string[] args)
        {
           // Создание своей функции (вторая часть внизу)
          Print("Hi!");
          int num;
          num = Summ (4,10);

          Print (num);
          
          
          
          
          
          // Method ForEACH перебор элементов в массиве:

            // float[] nums = {1.23f, 5.32f, 7.56f};

            // foreach(float el in nums) {
            //     Console.WriteLine("Element is :" + el);
            // }






        //   int[,] arr = new int[3,2] {
        //       {2, 8}, {23, 5}, {87, 21}
        //   };

        //   for (int i = 0; i < 3; i++){
        //       for(int  j = 0; j < 2;j++){
        //             Console.Write(arr[i, j] + "  ");
        //       }
        //       Console.WriteLine("  ");

        //   }
            // List<int> nums = new List<int> ();

            // nums.Add (73);
            // nums.Add (49);


            // // int [] array = new int [5];
            // // string[] names = new string [3]{
            // //     "Georg", "Tom", "Gleb"
            // // };
            // for (int i = 0; i < nums.Count; i++){
            // Console.WriteLine (nums [i]+ ", ");
            // }



            // int i = 100;

            // do {
            //     Console.WriteLine ("Element i is :" + i);
            // }
            // while(i < 10);
            // int i = 0;

            // while (i < 10)
            
            // {Console.WriteLine ("Element i is :" + i);
            // i++;}

     }
        // Создание своей функции 
    public static void Print (string str){
        Console.WriteLine (str);
        }

    public static void Print (int num){
        Console.WriteLine (num);
        }

    public static int Summ (int a, int b){
        int res;
        res = a+b;

        return res;
        }
    }
}
