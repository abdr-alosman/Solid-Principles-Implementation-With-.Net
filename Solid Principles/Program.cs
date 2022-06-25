using Solid_Principles.Dependency_Inversion;
using Solid_Principles.Liskov_Substitution;
using Solid_Principles.Open_Closed;


// Open Close Client

InvoiceOCP FInvoice = new FinalInvoice();
InvoiceOCP PInvoice = new ProposedInvoice();
InvoiceOCP RInvoice = new RecurringInvoice();

double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);

Console.WriteLine(FInvoiceAmount);
Console.WriteLine(PInvoiceAmount);
Console.WriteLine(RInvoiceAmount);

// Open Close Client

// Liskov Substitution

List<string> fruts = new List<string>
{
    "Apple","Orange","Banana"
};

Fruit fruit;



foreach (var item in fruts)
{
    if (item.StartsWith("A"))
    {
        fruit = new Apple1();
    }
    else if (item.StartsWith("O"))
    {
        fruit = new Orange1();
    }
    else
    {
        fruit = new Fruit();
    }
    Console.WriteLine(fruit.GetColor());

}


// Liskov Substitution


//Dependency Inversion

// constractor injection
Notification1 notification =new Notification1(new WebMail());

// property injection
notification.mailType = new Gmail1();
notification.SendMail();

Console.ReadKey();

//Dependency Inversion
