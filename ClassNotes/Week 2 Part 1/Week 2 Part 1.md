# Week 2 Part 1

# C# Language

# Overview
- C# tied to .NET versions [ref](https://www.c-sharpcorner.com/article/c-sharp-versions/)
- Hello World App
    - White spaces are ignored
- `using` vs `import`
    - grey out is unused
    - `System.Console` vs `using System`
    - how does using impact dll in bin
- `namespace` vs `package`
    - namespaces has `{ }`, how is that better
    - when to namespace?
- Commenting
    - `//` - inline comments (C++)
    - `/* */` - C style
    - `///` - XML comments
        - summary
        - args
        - params
        - return
    
# System Input Output
- `Console.Write`
- `Console.WriteLine`
- `Console.ReadLine`
    - no scanner object!
    - text is read, needs parsing

# C# types
- Simple Types
    - sbyte (`System.SByte`)
    - byte (`System.Byte`)
    - short (`System.Int16`)
    - ushort (`System.UInt16`)
    - int (`System.Int32`)
    - uint (`System.UInt32`)
    - long (`System.Int64`)
    - ulong (`System.UInt64`)
    - char (`System.Char`)
    - float (`System.Single`)
    - double (`System.Double`)
    - bool (`System.Boolean`)
    - decimal (`System.Decimal`)
- Class Types
    - `System.Object`
    - `System.String`
    - `System.Value`
    - `System.Enum`
    - `System.Array`
    - `System.Delegate`
    - `System.Exception`
- What is the decimal type?
- Data Type Suffix
    - The data type suffix helps the compiler to unambiguously identify the data type of any value/literal.
        ```
        long myVal2 = 4294967296L;
        decimal myMoney = 300.5m;
        float myRadius = 3.145f;
        ```
- Type conversion
    - `int.Parse` vs `Convert.ToInt32` (throws argumentnullexception)
    - `int.Parse` vs `int.TryParse`
    - casting
- Explicit vs Implicit declaration (`var`)

# Strings
- `string` vs `String` (string is keyword)
- anything within `""`, including spaces
- string interpolation
    - `"Hello " + var` (string concatenation)
    - `("Hello {0}, var)` (composite formatting)
    - `$"Hello {var}"` (string interpolation)
    - `@"Hello \t World"` (verbatim string)
    - `$@ Hello World from \t {var}` (verbatim string interpolation)
    -  """ Raw String Literals (required C# 11+; NET 7.0) [ref](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/raw-string)
        ```
            string jsonString = """
            {
                "Date": "2019-08-01T00:00:00-07:00",
                "TemperatureCelsius": 25,
                "Summary": "Hot",
                "DatesAvailable": [
                    "2019-08-01T00:00:00-07:00",
                    "2019-08-02T00:00:00-07:00"
                ],
                "TemperatureRanges": {
                    "Cold": {
                    "High": 20,
                    "Low": -10
                    },
                    "Hot": {
                    "High": 60,
                    "Low": 20
                    }
                            },
                "SummaryWords": [
                    "Cool",
                    "Windy",
                    "Humid"
                ]
            }
            """; 
        ```
        there are rules to this, see https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#raw-string-literals
- escape characters
    - `\r` `\n` `\t` `\\`

# Objects
- Getters Setters vs Properties
    - `this`
    - GetName SetName vs get set (aka Properties)
        ```
        private string name;
        public string GetName(){...}
        public string SetName(string value){...}
        ```
        ```
        private string name;
        public string Name{ get { return this.name; } set { this.name = value;} }
        ```
        ```
        public string Name {get;set;}
        ```
    
    - how to encapsulate? 
    - how to overload?
    - error handling / defensive coding
- Read-Only instance variables
    - `private readonly int _year;`
- Constructors
    ```
    public Account () {...}
    public Account (int balance) {...}

    Account a = new Account();
    Account b = new Account(20);
    var c = new Account() { Balance = 20 }
    ```




