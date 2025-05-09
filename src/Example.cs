public class Example {
    public string name; // Still non-PascalCase
    public void Process() {
        Console.WriteLine(name); // Still null reference risk
        string secret = "apiKey=12345"; // Hard-coded secret
        string query = "SELECT * FROM users WHERE id = " + userInput; // SQL injection risk
        int value = 0; // Unused variable
    }
}