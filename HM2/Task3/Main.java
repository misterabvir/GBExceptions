package Task3;

/**
 * Дан следующий код, исправьте его там, где требуется (задание 3
 * https://docs.google.com/document/d/17EaA1lDxzD5YigQ5OAal60fOFKVoCbEJqooB9XfhT7w/edit)
 */

public class Main {
    public static void main(String[] args) throws Exception {
        arithmetic();
    }

    private static void arithmetic() throws Exception {
        try {
            int a = 90;
            int b = 3;
            System.out.println(a / b);
            printSum(23, 234);
            int[] abc = { 1, 2 };
            abc[3] = 9;
        } catch (IndexOutOfBoundsException ex) {
            System.out.println("Массив выходит за пределы своего размера!");
        }
    }

    private static void printSum(Integer a, Integer b) {
        System.out.println(a + b);
    }
}

/**
 * 30
 * 257
 * Массив выходит за пределы своего размера!
 */