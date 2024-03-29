Console.WriteLine("Стартовые деньги");

int money =  Convert.ToInt32(Console.ReadLine());
string[] categories =
{
    "Продукты",
    "Транспорт",
    "Учеба"
};

int [] validate = new int [categories.Length];
int indexcategory = 0 ;

while (money > 0 || money!= 0 )
{

   
    if (money > 0 )
    {
       
       
      
        for (int i = 1, j = 0; i < categories.Length+1; i++, j++)
        {
            
            if (validate[j] != i )
            {
                Console.WriteLine("выберите категорию");
                Console.WriteLine(i + categories[i-1]);
               
            }
            if (validate[0] == 1&& validate[1] == 2&& validate[2] == 3)
            {
                Console.WriteLine("Прошол месяц месяц удачно");
                
                
            }

            
        }
        indexcategory = Convert.ToInt32(Console.ReadLine());
        validate[indexcategory - 1] = indexcategory;
        

        Console.WriteLine($"сколько потратим на: {categories[indexcategory-1]}");
        int product = Convert.ToInt32(Console.ReadLine());
        money = money - product;
        Console.WriteLine($"потрачено {product} отсаток {money}");
       

    }
    else
    {
        Console.WriteLine("У вас теперь кредиты :)");
        break;
    }
  
}
Console.WriteLine(" денег на этот месяц нет");

