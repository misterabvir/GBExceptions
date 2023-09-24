package Task1;

import java.util.Scanner;

/**
 * Реализуйте метод, который запрашивает у пользователя ввод дробного числа
 * (типа float),
 * и возвращает введенное значение. Ввод текста вместо числа не должно приводить
 * к падению приложения,
 * вместо этого, необходимо повторно запросить у пользователя ввод данных.
 */
public class Main {
    public static void main(String[] args) {
        float input = getFloatInput();
        System.out.println("Result: " + input);
    }

    private static float getFloatInput() {
        float result = 0;
        boolean wrong = true;
        Scanner scanner = new Scanner(System.in);
        do {
            System.out.print("Type float number: ");
            if (scanner.hasNextFloat()) {
                result = scanner.nextFloat();
                wrong = false;
            } else {
                System.out.println("Your input must be float, try again");
                scanner.next();
            }
        } while (wrong);
        scanner.close();
        return result;
    }
}

/**
 * OUTPUT:
 * Type float number: wrong
 * Your input must be float, try again
 * Type float number: 45.1
 * Result: 45.1
 */