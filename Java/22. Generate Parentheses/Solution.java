import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

class Solution {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Number: ");
        int n = sc.nextInt();

        generateParenthesis(n);

        sc.close();

    }

    public static List<String> generateParenthesis(int n) {
        List<String> list = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            list.add("()");
        }

        System.out.println(list);
        return list;
    }
}