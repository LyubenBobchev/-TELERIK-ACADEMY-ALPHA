//7.Sorting array (bubble sort)

function sortingArray(arraySize, array) {

    const size = +arraySize;
    let arrayNum = array.split(' ').map(Number);

    var swapped;

    do {
        swapped = false;

        for (let i = 0; i < size - 1; i++) {
    
            if (arrayNum[i] > arrayNum[i + 1]) {
                let temp = arrayNum[i + 1];
                arrayNum[i + 1] = arrayNum[i];
                arrayNum[i] = temp;
                swapped = true;
            }   
        }
        size--;
    } while (swapped);
}