namespace AdapterPatternComposition;

internal class Program
{
    static void Main(string[] args)
    {
        LegacyPrinter legacyPrinter = new LegacyPrinter();
        Newprinter newprinter = new Newprinter();
        IPrinter printer = new PrinterAdapter(legacyPrinter, newprinter);
        printer.Print("Hello, Object Adapter Pattern!");
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
    public void Print(string text)
    {
        Console.WriteLine("Printing using LegacyPrinter: " + text);
    }
}

public class Newprinter
{
    public void Print(string text)
    {
        Console.WriteLine("Printing using NewPrinter: " + text);
    }

}

// Adapter (Object adapter)
public class PrinterAdapter : IPrinter
{
    private readonly LegacyPrinter _legacyPrinter;
    private readonly Newprinter _newPrinter;

    public PrinterAdapter(LegacyPrinter legacyPrinter, Newprinter newprinter)
    {
        _legacyPrinter = legacyPrinter;
        _newPrinter = newprinter;
    }

    public void Print(string content)
    {
        // Delegate the call to LegacyPrinter
        _legacyPrinter.Print(content);
        _newPrinter.Print(content);
    }
}
