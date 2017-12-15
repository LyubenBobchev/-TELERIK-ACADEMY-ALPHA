// 3.Maximal sequence

function maximalSequence(input) {
    let maxSeq = 1;
    let currentMaxSeq = 1;
    for (var i = 0; i < input.length - 1; i++) {
        
        if (parseInt(input[i]) === parseInt(input[i + 1])) {
            currentMaxSeq++;
            if (currentMaxSeq > maxSeq) {
                maxSeq = currentMaxSeq;
            }
        }
        else {
            currentMaxSeq = 1;
        }
    }
    console.log(maxSeq);
}