public class Example {
    private String name; // Still missing Javadoc
    public void process() { // Still non-standard
        System.out.println(name); // Still null reference risk
        String conn = "jdbc:mysql://localhost?user=root&password=pass"; // Hard-coded credentials
        String unused = "test"; // Unused variable
    }
}