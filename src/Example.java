public class Example {
    private String name; // Missing Javadoc
    public void process() { // Non-standard naming
        System.out.println(name); // Potential null reference
        String conn = "jdbc:mysql://localhost?user=root&password=pass"; // Hard-coded credentials
    }
}