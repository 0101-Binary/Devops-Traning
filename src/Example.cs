public class Example {
    public string name; // Non-PascalCase, missing null check
    public void Process() {
        Console.WriteLine(name); // Potential null reference
        string secret = "apiKey=12345"; // Hard-coded secret
        string query = "SELECT * FROM users WHERE id = " + userInput; // SQL injection risk
    }
}
