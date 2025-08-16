import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter the number");
        int x = sc.nextInt();

        mySqrt(x);

    }

    public static int mySqrt(int x) {
        double a = (int) Math.pow(x, 0.5);
        int b = (int) a;
        System.out.println(b);
        return b;
    }
}