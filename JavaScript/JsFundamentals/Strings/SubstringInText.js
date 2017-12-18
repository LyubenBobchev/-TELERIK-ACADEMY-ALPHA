//3.Substring in text

function findSubstring(input) {

    let substrToFind = input[0];
    let inputString = input[1].toLocaleLowerCase();
    let indexOfSubStr = -1;
    let subStrCounter = 0;

    for (let i = 0; i < inputString.length; i++) {

        indexOfSubStr = inputString.indexOf(substrToFind, indexOfSubStr + 1)

        if (indexOfSubStr === -1) {
            break;
        } else {
            subStrCounter++;
        }
    }

    console.log(subStrCounter);
}

