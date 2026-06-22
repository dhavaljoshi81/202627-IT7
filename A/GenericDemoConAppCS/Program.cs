using GenericDemoConAppCS;

GenTestDataManager<Student> genTestDataManager = new GenTestDataManager<Student>();
genTestDataManager.Add(new Student { RNo = 1, Name = "Alice", Age = 20 });
genTestDataManager.Add(new Student { RNo = 2, Name = "Bob", Age = 22 });
genTestDataManager.Display();

//TestDataManager dataManager = new TestDataManager();
//dataManager.Add(10);
//dataManager.Add(20);
//Console.WriteLine("Test Data Manager:");
//dataManager.Display();



//DataManager<Student> dataManager = new DataManager<Student>();
//dataManager.Add(new Student { RNo = 1, Name = "Alice", Age = 20 });
//dataManager.Add(new Student { RNo = 2, Name = "Bob", Age = 22 });
//Console.WriteLine("Student Manager:");
//dataManager.Display();


//DataManager<int> intManager = new DataManager<int>();
//intManager.Add(10);
//intManager.Add(20);
//Console.WriteLine("Int Manager:");
//intManager.Display();
//Console.WriteLine("After removing 20 and adding 30:");
//intManager.Remove(20);
//intManager.Add(30);
//intManager.Display();


//DataManager<string> stringManager = new DataManager<string>();
//stringManager.Add("Hello");
//stringManager.Add("World");
//Console.WriteLine("String Manager:");
//stringManager.Display();
//Console.WriteLine("After removing 'Hello' and adding 'C#':");
//stringManager.Remove("Hello");
//stringManager.Add("C#");
//stringManager.Display();