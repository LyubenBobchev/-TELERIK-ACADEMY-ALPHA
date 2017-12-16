//6.First Largest Than Neighbours
function firstLargest(){

    const arraySize = +gets();
    const numberArray = +gets().split(' ').map(Number)
    let index = -1;
    
    for (let i = 1; i < arraySize - 1; i++) {
        
        if (numberArray[i] > numberArray[i - 1] && +numberArray[i] > numberArray[i + 1]) {
            index = i;
            break;
        }
    }
    
    print(index);
    quit(0);
}

