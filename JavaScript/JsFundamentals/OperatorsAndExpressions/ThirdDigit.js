//4.Third diggit

function thirdDiggit(input){
    let position = Math.floor(input / 100);
    let thirdDiggit = position % 10;
        if (thirdDiggit === 7) {
        console.log('true');
    } else {
        console.log('false'+' '+thirdDiggit);
    }
}