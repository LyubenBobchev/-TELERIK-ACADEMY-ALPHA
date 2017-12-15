//5.Selection sort ???

function selectionSort(array) {
    let input = [];

    for (var key in array) {
        input[key] = parseFloat(array[key])
    }
    for (var i = 0; i < input.length; i++) {
        
        let minNumIndex = i;
        
        for (var j = i; j < input.length; j++) {
            
            if (input[minNumIndex] > input[j]) {
                minNumIndex = j;
            }
        }
        
        let temp = input[i];
        input[i] = input[minNumIndex];
        input[minNumIndex] = temp;
    }

    for (var index = 0; index < input.length - 1; index++) {
        if (input[index] === input[index + 1]) {
            input.splice((index + 1), 1)
        }
    }
    for (var key in input) {
        console.log(input[key]);
    }
}