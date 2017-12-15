//8.Number as words

function numberAsWords(input) {
    let number = parseInt(input[0]);
    let hundreds = Math.floor(Math.abs(number / 100));
    let tens = Math.floor((number % 100) / 10);
    let ones = number % 10;

    if (hundreds > 0 && hundreds < 10) {
        switch (hundreds) {
            case 1:
                console.log("One hundred ");
                break;
            case 2:
                console.log("Two hundred ");
                break;
            case 3:
                console.log("Three hundred ");
                break;
            case 4:
                console.log("Four hundred ");
                break;
            case 5:
                console.log("Five hundred ");
                break;
            case 6:
                console.log("Six hundred ");
                break;
            case 7:
                console.log("Seven hundred ");
                break;
            case 8:
                console.log("Eight hundred ");
                break;
            case 9:
                console.log("Nine hundred ");
                break;
            default:
                console.log();
                break;
        }
        if ((tens === 0 && ones > 0) || tens === 1) {
            Console.Write("and ");
        }
    }
    if (tens === 1) {
        switch (ones) {
            case 0:
                console.log("Ten");
                break;
            case 1:
                console.log("Eleven");
                break;
            case 2:
                console.log("Twelve");
                break;
            case 3:
                console.log("Thirteen");
                break;
            case 4:
                console.log("Fourteen");
                break;
            case 5:
                console.log("Fifteen");
                break;
            case 6:
                console.log("Sixteen");
                break;
            case 7:
                console.log("Seventeen");
                break;
            case 8:
                console.log("Eighteen");
                break;
            case 9:
                console.log("Nineteen");
                break;
            default:
                console.log();
                break;
        }
    }
    if (tens > 1) {
        switch (tens) {
            case 2:
                console.log("Twenty ");
                break;
            case 3:
                console.log("Thirty ");
                break;
            case 4:
                console.log("Fourty ");
                break;
            case 5:
                console.log("Fifty ");
                break;
            case 6:
                console.log("Sixty ");
                break;
            case 7:
                console.log("Seventy ");
                break;
            case 8:
                console.log("Eighty ");
                break;
            case 9:
                console.log("Ninety ");
                break;
            default:
                console.log();
                break;
        }
    }
    if (tens !== 1) {
        switch (ones) {
            case 1:
                console.log("One");
                break;
            case 2:
                console.log("Two");
                break;
            case 3:
                console.log("Three");
                break;
            case 4:
                console.log("Four");
                break;
            case 5:
                console.log("Five");
                break;
            case 6:
                console.log("Six");
                break;
            case 7:
                console.log("Seven");
                break;
            case 8:
                console.log("Eight");
                break;
            case 9:
                console.log("Nine");
                break;
            default:
                console.log();
                break;
        }
    }
    if (hundreds === 0 && tens === 0 && ones === 0) {
        console.log("Zero");
    }
}