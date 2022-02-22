import java.util.Scanner;

public class Exercise2 {
    

    static boolean checkID (String card) { //function to chekID
        String text1 = "No ID card provided, or invalid ID card";
        String text2 = "Welcome to your favourite bank.";

        boolean bol1 = Character.isDigit(card.charAt(0)); //to check if it a number
        boolean bol2 = Character.isUpperCase(card.charAt(0)); // to chek if it is an upper case

        if (card == "") {  //chek if card is not empty
            System.out.println(text1);
            return false;
        }

        if (bol1 == true || bol2 == true) { //chek if the card starts with a number or an upper case
            for (int j = 1; j < card.length()-2; j++) { //chek the 7 digits in between
                if (Character.isDigit(card.charAt(j)) == false) {
                    System.out.println(text1);
                    return false;
                }
            }
            if (Character.isUpperCase(card.charAt(8)) == false) { //chek the last digit is an upper case
                System.out.println(text1);
                return false;
            }
        }
        else {
            System.out.println(text1);
            return false;
        }
        System.out.println(text2);
        return true; 

    } //end checkID

    static boolean checkName(String name) { //this function checks each word of the user name
        if (Character.isUpperCase(name.charAt(0))) { //check upper case
            for (int j = 1; j < name.length()-1; j++) { //check the lower cases
                if (Character.isLowerCase(name.charAt(j)) == false) {
                    return false;
                }
            }
            return true;
        }
        return false;
    }

    static boolean checkUserName(String completeName) {

        String[] splitName = completeName.split(" "); //first we get each word of the name and do an array out of it
        String text1 = "No name provided, or invalid name";
        String text2 = "Welcome, name is correct";

        if (completeName != "") { //check if name is not empty
            if (splitName.length >= 3) { //the name must be 3 words or more
                for (int i = 0; i < splitName.length; i++) {
                    if (!checkName(splitName[i])) { //with the function we check each word of the name
                        System.out.println(text1);
                        return false;
                    }
                }
                System.out.println(text2);
                return true;
            }
            else {
                System.out.println(text1);
                return false;
            }
        }
        else {
            System.out.println(text1);
            return false;
        }
        
    }// end checkUsersName

    
    static boolean checkBankAccount(String bankAccount) {
        String text1 = "Bank account is not valid";
        bankAccount = bankAccount.replace(" ", ""); // we replace the gaps between the numbers for nothing

        if (bankAccount.length() == 24) { //a bank account has 24 digits
            if (Character.isUpperCase(bankAccount.charAt(0)) && Character.isUpperCase(bankAccount.charAt(1))) { //check the first two digirs are upper cases
                for (int i = 2; i < bankAccount.length()-1; i++) { //check if the other digits are numbers
                   if (!Character.isDigit(bankAccount.charAt(i))) {
                        System.out.println(text1);
                        return false;
                   }
                }
                return true;
            }
        } 
        System.out.println(text1);
        return false;
    }//end checkBankAccount

    static boolean checkBalance(float balance) {
        String text1 = "Initial balance can't be negative";

        if (balance > 0) { //check if balance is positive
            return true;
        }
        else {
            System.out.println(text1);
            return false;
        }
    }//end checkBalance

    static String infoProvided(String card, String completeName, String bankAccount, float balance) {//function to show all the info provided
        String text = "This is the information that you have provided: \n";
        text+= "ID card: "+ card + "\n";
        text+= "Full name: "+ completeName + "\n";
        text+= "Bank account: "+ bankAccount + "\n";
        text+= "Initial balance: "+ String.format("%.2f", balance) + " EUR";

        return text;

    }//end infoProvided

    public static void main(String[] args) {
        
        String card;
        String completeName;
        String bankAccount;
        float balance;
        Scanner sc = new Scanner(System.in);

        if (args.length > 0) {
            card = args[0];
            
            if(checkID(card)) { //if card is correct ask the user name
                System.out.print("Please, enter you full name:");
                completeName = sc.nextLine();

                if(checkUserName(completeName)) { //if user name is correct ask the user bank account
                    System.out.println("Please, enter your bank account");
                    bankAccount = sc.nextLine();

                    if (checkBankAccount(bankAccount)) { //if bank account is correct ask the balance
                        System.out.println("Please, enter your initial balance");
                        balance = sc.nextFloat();

                        if (checkBalance(balance)) { //if balance is correct then it appear a message
                            System.out.println("You've finished the registration successfully!");
                            System.out.println(infoProvided(card, completeName, bankAccount, balance));
                        }
                    }
                }
            }
        }
        else {
            System.out.print("No ID card provided, or invalid ID card");
        }

    }// end of main
}

