//5.Replace with &nbsp;

function replace(input) {

    let regEx = / /g;
    return input[0].replace(regEx, '&nbsp;')
}

console.log(replace(['This text contains 4 spaces!!']));