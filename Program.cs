/*Разработайте систему для управления животным приютом. 
В вашем приюте могут находиться различные виды животных, такие как кошки, собаки, птицы и рептилии. 
Каждое животное имеет уникальный идентификатор, кличку и возраст.

Требования:

Создайте интерфейс IAnimal, который содержит следующие методы:

void MakeSound(), который будет выводить звук, издаваемый животным.
string GetInfo(), который будет возвращать информацию о животном в виде строки.
Создайте абстрактный класс Animal, реализующий интерфейс IAnimal. В этом классе определите следующие общие свойства:

Уникальный идентификатор животного.
Кличку животного.
Возраст животного.
Создайте классы Cat, Dog, Bird и Reptile, наследующиеся от класса Animal. 
Каждый из этих классов должен реализовывать методы интерфейса IAnimal в соответствии с особенностями соответствующего вида животного.

Создайте класс AnimalShelter, который будет содержать список животных в приюте. Реализуйте следующие методы:

void AddAnimal(Animal animal), для добавления животного в приют.
void RemoveAnimal(Animal animal), для удаления животного из приюта.
void PrintAnimals(), для вывода информации о всех животных в приюте.
Создайте программу, которая демонстрирует работу вашей системы управления животным приютом. 
Программа должна содержать меню с возможностью добавления и удаления животных, а также просмотра информации о животных.*/




AnimalShelter animalShelter = new AnimalShelter();
Console.WriteLine("\t\t\tCистема управления животным приютом");
int key;
do
{
    Console.WriteLine("\t\t\tВыберите действие:");
    Console.WriteLine("\t\t\t");
    Console.WriteLine("\t\t\tДобавить животное - 1");
    Console.WriteLine("\t\t\tУдалить животное -2");
    Console.WriteLine("\t\t\tПоказать список животных - 3");
    Console.WriteLine("\t\t\tВыйти - 4");

    while (!int.TryParse(Console.ReadLine(), out key))
    {
        Console.WriteLine("\t\t\tВыберите действие:");
        Console.WriteLine("\t\t\t");
        Console.WriteLine("\t\t\tДобавить животное - 1");
        Console.WriteLine("\t\t\tУдалить животное -2");
        Console.WriteLine("\t\t\tПоказать список животных - 3");
        Console.WriteLine("\t\t\tВыйти - 4");
    }

        if (key == 1)
    {
        Console.WriteLine();
        animalShelter.AddAnimal();
        Console.WriteLine();
    }

    if(key == 2)
    {
        Console.WriteLine();
        animalShelter.RemoveAnimal();
        Console.WriteLine();
    }

    if(key == 3)
    {
        Console.WriteLine();
        animalShelter.PrintAnimals();
        Console.WriteLine();
    }

    if(key == 4)
    {
        Environment.Exit(4);
    }
} while (key != 0);



interface IAnimal
{
    void MakeSound();
    void GetInfo();

}

 abstract class Animal : IAnimal
{
    public abstract void MakeSound();
    public abstract void GetInfo();

    protected string AnimalId { get; set; }
    protected string Name { get; set; }
    protected int Age { get; set; }

    public Animal(string animalId, string name, int age, string sound)
    {
        AnimalId = animalId;
        Name = name;
        Age = age;
        Sound = sound;
    }

    protected string Sound { get; set; }
}

class Cat : Animal
{
    public Cat(string animalId, string name, int age, string sound) : base(animalId, name, age, sound)
    {

    }

    public override void GetInfo()
    {
        Console.WriteLine($"Идентификатор: {AnimalId}");
        Console.WriteLine($"Кличка: {Name}");
        Console.WriteLine($"Возраст: {Age}");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"Звук: {Sound}");
    }
}

class Dog : Animal
{
    public Dog(string animalId, string name, int age, string sound) : base(animalId, name, age, sound)
    {

    }

    public override void GetInfo()
    {
        Console.WriteLine($"Идентификатор: {AnimalId}");
        Console.WriteLine($"Кличка: {Name}");
        Console.WriteLine($"Возраст: {Age}");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"Звук: {Sound}");
    }
}

class Bird : Animal
{
    public Bird(string animalId, string name, int age, string sound) : base(animalId, name, age, sound)
    {

    }

    public override void GetInfo()
    {
        Console.WriteLine($"Идентификатор: {AnimalId}");
        Console.WriteLine($"Кличка: {Name}");
        Console.WriteLine($"Возраст: {Age}");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"Звук: {Sound}");
    }
}

class Reptile : Animal
{
    public Reptile(string animalId, string name, int age, string sound) : base(animalId, name, age, sound)
    {

    }

    public override void GetInfo()
    {
        Console.WriteLine($"Идентификатор: {AnimalId}");
        Console.WriteLine($"Кличка: {Name}");
        Console.WriteLine($"Возраст: {Age}");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"Звук: {Sound}");
    }
}


class AnimalShelter
{
    Animal animal;

    List<string> animal_list = new List<string>() {};

    public string animalid_for_input;
    public string name_for_input;
    public int age_for_input;
    public string sound_for_input;

    public string animalid_for_delete;
    public string name_for_delete;
    public int age_for_delete;
    public string sound_for_delete;

    public void AddAnimal()
    {
       
            Console.Write("Введите идентификатор животного: (Cat, Dog, Bird, Reptile): ");
            animalid_for_input = Console.ReadLine();
            Console.WriteLine();
           
            Console.Write("Введите кличку животного: ");
            name_for_input = Console.ReadLine();
            Console.WriteLine();
         
            Console.Write("Введите возраст животного: ");
            age_for_input = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            Console.Write("Введите звук животного: ");
            sound_for_input = Console.ReadLine();
            Console.WriteLine();    
      
            if (animalid_for_input == "Cat")
            {
                animal_list.Add($"{animal = new Cat(animalid_for_input, name_for_input, age_for_input, sound_for_input)}\n");
            }

            if (animalid_for_input == "Dog")
            {
                animal_list.Add($"{animal = new Dog(animalid_for_input, name_for_input, age_for_input, sound_for_input)}\n");
            }

            if (animalid_for_input == "Bird")
            {
                animal_list.Add($"{animal = new Bird(animalid_for_input, name_for_input, age_for_input, sound_for_input)}\n");
            }

            if (animalid_for_input == "Reptile")
            {
                animal_list.Add($"{animal = new Reptile(animalid_for_input, name_for_input, age_for_input, sound_for_input)} \n");
            }
    }
    public void RemoveAnimal()
    {
        
            Console.Write("Введите идентификатор животного для удаления: (Cat, Dog, Bird, Reptile): ");
            animalid_for_delete = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("Введите кличку животного для удаления: ");
            name_for_delete = Console.ReadLine();
            Console.WriteLine();

               
            Console.Write("Введите возраст животного для удаления:");
            age_for_delete = Convert.ToInt32(Console.ReadLine());
                    
            Console.WriteLine();
            Console.Write("Введите звук животного для удаления: ");
            sound_for_delete = Console.ReadLine();
            Console.WriteLine();
       
        

           animal_list.Add($"{animalid_for_delete}, {name_for_delete}, {age_for_delete}, {sound_for_delete}\n");
           animal_list.Clear();


    }

    public void PrintAnimals()
    {
        foreach (var show in animal_list)
        {
            Console.WriteLine(show);
            animal.GetInfo();
            animal.MakeSound();
        }
        
        
    }

    
}

