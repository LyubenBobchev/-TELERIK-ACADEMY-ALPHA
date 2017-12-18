//2.Correct brackets 

function correctBrackets(input) {
    let strArray = input.toString().split('');

    let openBracketsCounter = 0;
    let closeBracketsCounter = 0;

    strArray.forEach(element => {
        switch (element) {
            case '(':
                openBracketsCounter++
                break;
            case ')':
                closeBracketsCounter++
                break;
            default:
                break;
        }
    });


    if (openBracketsCounter !== closeBracketsCounter) {
        console.log("Incorrect")
    }

    else {
        console.log('Correct')
    }
}
