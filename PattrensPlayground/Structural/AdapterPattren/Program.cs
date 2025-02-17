namespace AdapterPattern;

internal class Program
{
    static void Main(string[] args)
    {
        IPrinter printer = new PrinterAdapter();
        printer.Print("Hello, Adapter Pattern!");
    }
}

// Target interface
public interface IPrinter
{
    void Print(string content);
}


// Adaptee (Legacy class)
public class LegacyPrinter
{
    public void OldPrint(string text)
    {
        Console.WriteLine("Printing using LegacyPrinter: " + text);
    }
}

// Adapter (Class adapter)
public class PrinterAdapter : LegacyPrinter, IPrinter
{
    public void Print(string content)
    {
        // Call the method from the LegacyPrinter
        OldPrint(content);
    }
}