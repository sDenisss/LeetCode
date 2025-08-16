import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter the digit: ");
        int a = sc.nextInt();

        if (isPalindrome(a) == true) {
            System.out.println("true");
        } else {
            System.out.println("false");
        }

        sc.close();
    }

    public static boolean isPalindrome(int x) {
        int original = x;
        int reversed = 0;

        if (x >= 0) {
            while (x != 0) {
                int lastDigit = x % 10;
                reversed = reversed * 10 + lastDigit;
                x /= 10;
            }
            System.out.println(reversed + " " + original);
        } else {
            return false;
        }

        return original == reversed;
    }

}