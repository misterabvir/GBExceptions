package Task4;

public class EmptyStringException extends Exception {
    public EmptyStringException() {
        super("Inputted string can't be empty, try again.");
    }
}
