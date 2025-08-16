import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        Solution solution = new Solution();
        int[] arr = solution.createArray();
        System.out.println(Arrays.toString(arr));
        System.out.println(solution.findMaxK(arr));

        sc.close();
    }
}