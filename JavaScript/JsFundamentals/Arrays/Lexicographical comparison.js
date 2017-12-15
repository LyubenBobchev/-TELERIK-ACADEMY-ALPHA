//2. Lexicographically comparison

function lexigrpComparison(input) {

    let charArrayA = input[0].split(''); 
    let charArrayB = input[1].split(''); 
    let maxIndex = Math.max(charArrayA.length, charArrayB.length); 
    for (var i = 0; i < maxIndex; i++) {
        if (charArrayA[i] > charArrayB[i]) {
            
            console.log('>'); 
            return; 
        }
        if (charArrayA[i] < charArrayB[i]) {
            
            console.log('<'); 
            return 
        }
        if (charArrayA[i] === charArrayB[i]) {
            continue; 
        }
    }
    if (charArrayA.length > charArrayB.length) {
        console.log('>'); 
    }
    else if (charArrayA.length < charArrayB.length) {
        console.log('<'); 
    }
    else {
        console.log('='); 
    }
}