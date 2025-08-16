import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter word: ");
        String word = sc.nextLine(); // abcdef->edcbaf
        System.out.println("Enter ch: ");
        char ch = sc.next().charAt(0); // read the character from user input
        Solution solution = new Solution();
        String word2 = solution.reversePrefix(word, ch);
        int index_ch = word.indexOf(ch);

        System.out.println(word);
        System.out.println(index_ch);
        System.out.println(word2);
    }
}