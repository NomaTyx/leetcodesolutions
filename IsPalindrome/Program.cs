//leetcode easy*
//i did the added challenge of doing so without using a string
Console.WriteLine(IsPalindrome(123454321));

bool IsPalindrome(int x) {
    //negative number will never be a palindrome because it starts with a - but does not end with a -
    if (x < 0) {
        return false;
    }

    //gotta break the number into two parts without using a string. 
    //this can be done by figuring out half the number of the digits
    //log10 of a number returns a double where the whole number component is equal to one minus the number of digits
    //the decimal component is truncated, and then one is added to represent the number of digits
    //always casting as an int because c# doesn't truncate by default
    int numOfDigits = (int)Math.Log(x, 10) + 1;

    //single-digit number will always be a palindrome
    if (numOfDigits == 1) {
        return true;
    }

    //if you do this, you'll get the right half of a number (1234 % 10^2 = 1234 % 100 = 34)
    int rightHalf = (int)(x % Math.Pow(10, numOfDigits / 2));
    
    //left half is similar except we're dividing instead of using mod (1234 / 100 = 12r34)
    
    int leftHalf = (int)(x / Math.Pow(10, numOfDigits / 2 + numOfDigits % 2));
    /*gotta add numOfDigits % 2 because if it's odd, the left and right halves will have different numbers of digits. 
    if there's only one digit in the middle, if the rest of the number is a palindrome, the whole number will still be a palindrome
    for example, 12321. left half is 12, right half is 21. 1221 is a palindrome, therefore 12n21 will always be a palindrome no matter what digit n is.*/

    //now we gotta reverse the right half, because right now all we've done is divide the number into two

    int flippedRightHalf = 0;
    
    //loop through each digit in the right half. get that digit, truncate the ends, then multiply by 10 to the power of the digit slot it should occupy
    for(int i = 1; i <= numOfDigits / 2; i++) {
        flippedRightHalf += (int)((int)(rightHalf % Math.Pow(10, i) / Math.Pow(10, i - 1)) * Math.Pow(10, numOfDigits / 2 - i));
    }

    //self-explanatory
    return flippedRightHalf == leftHalf;
}