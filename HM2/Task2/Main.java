package Task2;

/**
 * Если необходимо, исправьте данный код (задание 2
 * https://docs.google.com/document/d/17EaA1lDxzD5YigQ5OAal60fOFKVoCbEJqooB9XfhT7w/edit)
 */
public class Main {
    public static void main(String[] args) {
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        int[] array2 = { 1, 2, 3, 4 };
        divideElement8(array1, 5);
        divideElement8(array1, 0); // throw ArithmeticException
        divideElement8(array2, 5); // throw IndexOutOfBoundsException
        divideElement8(array2, 0); // throw IndexOutOfBoundsException
    }

    private static void divideElement8(int[] array, int divider) {
        try {
            double result = array[8] / divider;
            System.out.println("result = " + result);
        } catch (IndexOutOfBoundsException e) {
            System.out.println("Catching exception: " + e);
        } catch (ArithmeticException e) {
            System.out.println("Catching exception: " + e);
        }
    }
}

/**
 * OUTPUT:
 * result = 1.0
 * Catching exception: java.lang.ArithmeticException: / by zero
 * Catching exception: java.lang.ArrayIndexOutOfBoundsException: Index 8 out of
 * bounds for length 4
 * Catching exception: java.lang.ArrayIndexOutOfBoundsException: Index 8 out of
 * bounds for length 4
 */
