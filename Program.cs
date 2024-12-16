namespace lesson16_12;

class Program
{
    static void Main(string[] args)
    {
        func_1(2, 10, false);
    }

    public static void func_1(int a, int b, bool c){
        for (int i = a; i <= b; i++){
            if(c == true){
                if(i % 2 == 0){
                    Console.WriteLine(i);
                }
            }
            else{
                if(i % 2 != 0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
