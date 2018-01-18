//Functions and Function Expressions

//1.Task1
function parseFunc(input) {
    let sum = 0;

    if (input === undefined) {
        return undefined;
    }

    if (input.length === 0) {
        return null;
    }

    input.forEach(element => {
        element = +element;

        if (isNaN(element)) {
            throw new Error("Parameter is not a number!");
        }

        sum += element;
    });

    return sum;
}
