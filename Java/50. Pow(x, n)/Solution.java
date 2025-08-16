import java.util.Scanner;

class Solution {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter the number: ");
        double x = sc.nextDouble();
        System.out.println("Enter the pow: ");
        int n = sc.nextInt();

        double result = new Solution().myPow(x, n);
        System.out.println(result);

        sc.close();
    }

    public static double myPow(double x, int n) {
        return Math.pow(x, n);
    }
}