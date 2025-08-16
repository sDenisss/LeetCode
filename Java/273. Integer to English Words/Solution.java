import java.util.Scanner;

class Solution {

    static String h1[] = { "Zero", "One", "Two", "Three", "Four", "Five", "Six",
            "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen",
            "Forteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen",
            "Nineteen" };
    static String h2[] = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy",
            "Eighty", "Ninety" };
    static String h3[] = { "Hundred", "Thousand", "Hundred Thousand", "Ten Million", "Billion" };

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Number: ");
        int num = sc.nextInt();

        numberToWords(num);

        sc.close();
    }

    public static String numberToWords(int num) {
        String word = "";

        if (num < 0) {
            word += "Minus ";
            num = -num;
        }

        if (num < 20) {
            word += h1[num];
        } else if (num < 100) {
            int temp = num / 10 - 2;
            word += h2[temp];

            temp = num % 10;
            if (temp > 0) {
                word += " " + numberToWords(temp);
            }
        } else if (num < 1000) {
            int temp = num / 100;
            word += numberToWords(temp) + " " + h3[0];

            temp = num % 100;
            if (temp > 0) {
                word += " " + numberToWords(temp);
            }
        } else if (num < 1000000) {
            int temp = num / 1000;
            word += numberToWords(temp) + " " + h3[1];

            temp = num % 1000;
            if (temp > 0) {
                word += " " + numberToWords(temp);
            }
        } else if (num < 1000000000) {
            int temp = num / 1000000;
            if (num == 1000000) {
                word += "One ";
            }
            word += numberToWords(temp) + " " + h3[2];

            temp = num % 1000000;
            if (temp > 0) {
                word += " " + numberToWords(temp);
            }
        } else if (num < 1000000000) {
            int temp = num / 10000000;
            word += numberToWords(temp) + " " + h3[3];

            temp = num % 10000000;
            if (temp > 0) {
                word += " " + numberToWords(temp);
            }
        } else if (num <= 2147483647) {
            int temp = num / 1000000000;
            word += numberToWords(temp) + " " + h3[4];

            temp = num % 1000000000;
            if (temp > 0) {
                word += " " + numberToWords(temp);
            }
        }

        System.out.println(word);
        return word;

    }
}