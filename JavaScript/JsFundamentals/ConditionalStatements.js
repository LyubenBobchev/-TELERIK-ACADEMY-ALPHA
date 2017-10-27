//1.Exchange if greater

function exchangeIfGreater(input) {
    let aletiable = parseFloat(input[0]);
    let bletiable = parseFloat(input[1]);
    let temp = 0;

    if (aletiable > bletiable) {
        temp = aletiable;
        aletiable = bletiable;
        bletiable = temp;
        console.log(aletiable + ' ' + bletiable)
    }
    else {
        console.log(aletiable + ' ' + bletiable)
    }
}

//2.Mutliplication Sign

function multiplicationSign(input) {
    let a = parseInt(input[0]);
    let b = parseInt(input[1]);
    let c = parseInt(input[2]);

    if (a === 0 || b === 0 || c === 0) {
        console.log(0);
    }
    else if (a > 0 && b > 0 && c > 0) {
        console.log('+');
    }
    else if (a < 0 && b < 0 && c < 0) {
        console.log('-');
    }
    else if (a > 0 && b < 0 && c < 0) {// a+ b- c-
        console.log('+');
    }
    else if (a > 0 && b > 0 && c < 0) {// a+ b+ c-
        console.log('-');
    }
    else if (a > 0 && b < 0 && c > 0) {// a+ b- c+
        console.log('-');
    }
    else if (a < 0 && b > 0 && c > 0) {// a- b+ c+
        console.log('-');
    }
    else if (a < 0 && b < 0 && c > 0) {// a- b- c+
        console.log('+');
    }
    else if (a < 0 && b > 0 && c < 0 ) {// a- b+ c-
        console.log('+');
    }
}

//3.The Biggest of three

function biggestOfThree(input) {
    let a = parseFloat(input[0]);
    let b = parseFloat(input[1]);
    let c = parseFloat(input[2]);
    
    if (a === b & b === c) {
        console.log(a)
    }
    else if (a >= b && b >= c) {
        console.log(a);
    }
    else if (a >= c && c >= b) {
        console.log(a);
    }
    else if (b >= a && a >= c) {
        console.log(b);
    }
    else if (b >= c && c >= a) {
        console.log(b);
    }
    else if (c >= b && b >= a) {
        console.log(c);
    }
    else if (c >= a && a >= b) {
        console.log(c);
    }
}

//4.Sort three numbers

function sortThreeNumbers(input) {
    let a = parseFloat(input[0]);
    let b = parseFloat(input[1]);
    let c = parseFloat(input[2]);
   
    if (a >= b && b >= c ) {
        console.log(`${a} ${b} ${c}`);
    }
    else if (a >= b && c >= b && a >= c) {
        console.log(`${a} ${c} ${b}`);
    }
    else if (b >= a && a >= c) {
        console.log(`${b} ${a} ${c}`);
    }
    else if (b >= a && c >= a && b >= c) {
        console.log(`${b} ${c} ${a}`);
    }
    else if (c >= a && a >= b) { 
        console.log(`${c} ${a} ${b}`);
    }
    else if (c >= a && b >= a && c >= b) {
        console.log(`${c} ${b} ${a}`);
    }
}

//5.Diggit as a word

function digitAsAWord(input) {
    let a = input[0];
    
    switch (a) {
        case '0':
        console.log('zero');
        break;
        case '1':
        console.log('one');
        break; 
        case '2':
        console.log('two');
        break; 
        case '3':
        console.log('three');
        break; 
        case '4':
        console.log('four');
        break;
        case '5':
        console.log('five');
        break; 
        case '6':
        console.log('six');
        break;
        case '7':
        console.log('seven');
        break; 
        case '8':
        console.log('eight');
        break; 
        case '9':
        console.log('nine');
        break; 
       default:
       console.log('not a digit');
       break;
    }
}

//6.Quadratic equation

function quadraticEquation(input) {
    let a = parseFloat(input[0]);
    let b = parseFloat(input[1]);
    let c = parseFloat(input[2]);
    let d = Math.pow(b, 2) - (4 * a * c);
    
    if (d < 0) {
        console.log('no real roots');
    }
    else if (d === 0) {
        let x = -1*b / (2*a);
        console.log(`x1=x2=${x.toFixed(2)}`);
    }
    else if (d > 0) {
        let x1 = ((-1 * b) - Math.sqrt(d)) / (2 * a);
        let x2 = ((-1 * b) + Math.sqrt(d)) / (2  *a);
        console.log(`x1=${x1.toFixed(2)}; x2=${x2.toFixed(2)}`);
    }
}

//7.The Biggest of five numbers
function biggestOfFive(input) {
    let a = parseFloat(input[0]);
    let b = parseFloat(input[1]);
    let c = parseFloat(input[2]);
    let d = parseFloat(input[3]);
    let e = parseFloat(input[4]);
    
    if (a>b && a>c && a>d && a>e)
    {
        console.log(a);
    }
    else if (b>a && b>c && b>d && b>e)
    {
        console.log(b);
    }
    else if (c>a && c>b && c>d && c>e)
    {
        console.log(c);
    }
    else if (d>a && d>c && d>b && d>e)
    {
        console.log(d);
    }
    else
    {
        console.log(e);
    }
}

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
numberAsWords(['999']);