using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {

        int method_show = 0;
        while(true)
        {
            if(method_show==0)
            {
                method_show = 1;
                Console.WriteLine("---------------Choose number of method you need to check ----------------");
                Console.WriteLine("1.hello world");
                Console.WriteLine("2. area of circle");
                Console.WriteLine("3.calculator with 2 numbers");
                Console.WriteLine("4.ascii");
                Console.WriteLine("5.Even odd method");
                Console.WriteLine("6.grade algorithm");
                Console.WriteLine("7.simple menue");
                Console.WriteLine("9.is this year Leap ???");
                Console.WriteLine("10.Angles problem");
                Console.WriteLine("11.Vowel or Consenant char");
                Console.WriteLine("12.geetign with hours");
                Console.WriteLine("12.tax problem");
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("ENter number from list above :   ");
            Console.WriteLine("--------------------------------------------------------------");
            int turn = Convert.ToInt32(Console.ReadLine()); 
            switch(turn)
            {
                case 1:
                    print_Hello();
                    break;
                case 2:
                    Console.WriteLine(AreaCircle(5));
                    break;
                case 3:
                    Console.Write("Enter number 1 : ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter number 1 : ");

                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter operator (+ ,-,/,*) : ");

                    char c = Convert.ToChar(Console.ReadLine());

                    Cacluator(x ,y ,c);
                    break;
                case 4:
                    Console.Write("Enter char to convert to ascci");

                    char cc = Convert.ToChar(Console.ReadLine());
                    ascii(cc);
                    break;
                case 5:
                    Console.Write("Enter number to check : ");
                    int number1= Convert.ToInt32(Console.ReadLine());
                    EvenOrOdd(number1);
                    break;
                case 6:
                    Console.Write("Enter grade : ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    GetGrade(number2);
                    break;
                case 7:
                    Console.WriteLine("Corner case ");
                    break;
                case 9:
                    Console.Write("Enter year: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"is this year leap ???  -- >> {is_Leap_Year (year)}");
                    break;
                case 10:
                    Console.Write("Enter angel 1 ");
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter angel 2 : ");
                    int a2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter angel 3 ");
                    int a3 = Convert.ToInt32(Console.ReadLine());
                    DetrmineTriangle(a1,a2,a3);
                    break;
                case 11:
                    VowelOrNot('a');
                    break;
                case 12:
                    Console.Write("Enter Salary :    ");
                    int salary = Convert.ToInt32(Console.ReadLine());
                    Taxes(salary);
                    break;
            }

        }


    } 
    public static void print_Hello()
    {
        Console.WriteLine("Hello world\n");
    } 
    public static double AreaCircle(double radius)
    {
        return (22/7.0) * radius * radius*1.0;
    } 

    public static void Cacluator(double x, double y ,char c)
    {
        switch(c)
        {
            case '+':
                Console.WriteLine(x+y);
                break;
            case '-':
                Console.WriteLine(x-y);
                break;
            case '*':
                Console.WriteLine(x*y);
                break;
            case '/':
                Console.WriteLine(x/y);
                break;
        }
    } 
    public static void ascii(char c)
    {
        Console.WriteLine($"the ascii value is equal ---->{ Convert.ToInt32(c)}\n");
    } 
    public static void EvenOrOdd(int num)
    {
        if(num%2==0 && num!=0)
        {
            Console.WriteLine("Even");
        } 
        else if(num%2!=0)
        {
            Console.WriteLine("Odd");
        } 
        else
            Console.WriteLine("Zerooo");
    } 
    public static void GetGrade(int grade)
    {
        if (grade < 60) Console.WriteLine("F\n");
        else if (grade >= 60 && grade < 70) Console.WriteLine("D\n");
        else if (grade >= 70 && grade < 80) Console.WriteLine("C");
        else if (grade>=80 && grade<90) Console.WriteLine("B"); 
        else if(grade>=90) Console.WriteLine("A");
    } 
    public static void Simple_Minue(int cut)
    {
         
            switch (cut)
            {

                case 1:
                    Console.WriteLine("Add");
                    break;
                case 2:
                    Console.WriteLine("Edit");
                    break;
                case 3:
                    Console.WriteLine("Display");
                    break;
                case 4:
                    break;
            }
 

    } 
    public static bool is_Leap_Year(int year)
    {
        return year % 4 == 0 || (year % 100 == 0 && year % 400 == 0);
    } 
    public static void DetrmineTriangle(int angle1  ,int angle2 ,int angle3)
    {
        if(angle1 ==angle2&& angle3 ==angle2)
        {
            Console.WriteLine("Acute");
        } 
        else if(angle1==90 || angle2 ==90 ||angle3 ==90)
        {
            Console.WriteLine("Right-angeled");
        } 
        else
            Console.WriteLine("obtuse");
    } 
    public static void VowelOrNot(char c)
    {
        if(c=='a' || c=='e' || c == 'i' || c == 'o' || c == 'u')
        {
            Console.WriteLine("Vowel");
        } 
        else
            Console.WriteLine("Consonent");
    } 
    public static void timeGreeting(int clock)
    {
        if(clock>=5 && clock <12)
            Console.WriteLine("Good Morning"); 
        else if(clock>=12 && clock<5)
            Console.WriteLine("Good afternoon"); 
        else
            Console.WriteLine("Good evening");
    } 
    public static void Taxes(int salary)
    {
        if(salary>=0 &&salary <=10000)
            Console.WriteLine("No tax Needed"); 
        else if(salary >10000 && salary <=50000)
            Console.WriteLine($"Tax need for this employee  = {(salary*10f)/100}"); 
        else if( salary >50000 && salary <=100000)
            Console.WriteLine($"Tax need for this employee  = {(salary * 20f) / 100}"); 
        else if(salary >100000)
            Console.WriteLine($"Tax need for this employee  = {(salary * 30f) / 100}");

    }
}                   