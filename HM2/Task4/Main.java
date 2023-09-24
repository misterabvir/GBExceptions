package Task4;

import java.util.Scanner;

/**
 * Разработайте программу, которая выбросит Exception, когда пользователь вводит
 * пустую строку.
 * Пользователю должно показаться сообщение, что пустые строки вводить нельзя.
 */

public class Main {

    static final String EMPTY = "";

    public static void main(String[] args) {
        try {
            String input = getStringInputWithException();
            System.out.println("Result: " + input);
        } catch (EmptyStringException ex) {
            System.out.println(ex);
        }
    }

    private static String getStringInputWithException() throws EmptyStringException {
        String input = EMPTY;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Type your string: ");
        input = scanner.nextLine();
        if (input.equals(EMPTY)) {
            scanner.close();
            throw new EmptyStringException();
        }
        scanner.close();
        return input;
    }
}

/** OUTPUT1:
 * Type your string: 
 * Task4.EmptyStringException: Inputted string can't be empty, try again.
 * OUTPUT2:
 * Type your string: string
 * Result: string
 */